using Server.Auxiliary;
using Server.Model;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AdapterAPI.Client
{
    public class ExchangeByUDP : AbstractClient
    {
        #region Переменные
        private UdpClient client;
        private Thread worker;
        private IReceiver master;
        #endregion
        #region Properties
        public byte[] ReceiveBuffer{ get; private set; }
        #endregion
        #region Методы
        public ExchangeByUDP(IReceiver receiver)
        {
            master = receiver;
        }
        public override void Connect(IPEndPoint remotePoint)
        {
            if (IsConnect)
            { Disconnect(); }

            RemoteEndPoint = remotePoint;
            client = new UdpClient(RemoteEndPoint.Port);
            client.EnableBroadcast = true;
            worker = new Thread(Receive);
            worker.IsBackground = true;
            worker.Start();
            OnStateChanged(true);
        }
        public override void Disconnect()
        {
            if (!IsConnect)
                return;
            
            client.Close();
            client = null;
            worker.Join(100);
            if (worker.IsAlive)
            {
                worker.Abort();
            }
            worker = null;
            OnStateChanged(false);
        }
        public override void Transmit(byte[] data)
        {
            try
            {
                if (data != null && data.Length > 0)
                { 
                    client.Send(data, data.Length, RemoteEndPoint);
                }
            }
            catch (Exception exception)
            {
                ExceptionProcess.Instance.ThrowException
                    ( Resources.glb_udpClient, Resources.scope_transmit, 
                    exception.Message, NotifyMessageType.WARNING);
            }
        }
        public void Receive()
        {
            bool isCorrectSender = false;
            byte[] buffer = null;
            IPHostEntry entries = null;
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, RemoteEndPoint.Port);
            IPEndPoint broadcastEndPoint = new IPEndPoint(IPAddress.Broadcast, 1000);
            IPEndPoint anyEndPoint = new IPEndPoint(IPAddress.Any, 1000);
            try
            {
                while (IsConnect && client != null)
                {
                    isCorrectSender = true;
                    buffer = client.Receive(ref sender);
                    RemoteEndPoint = sender;
                    entries = Dns.GetHostEntry(Environment.MachineName);

                    foreach (IPAddress addr in entries.AddressList)
                    {
                        if (sender.AddressFamily == addr.AddressFamily && sender.Address.Equals(addr))
                            isCorrectSender = false;
                    }

                    if (!isCorrectSender)
                        continue;

                    broadcastEndPoint.Port = sender.Port;
                    anyEndPoint.Port = sender.Port;

                    if (sender.Equals(broadcastEndPoint) || sender.Equals(anyEndPoint))
                        continue;

                    if (buffer == null)
                        continue;

                    byte[] result = master.ProcessData(buffer);
                    if (result != null)
                    {
                        OnDataReceive(result);
                    }
                }
            }
            catch (Exception exception)
            {
                if (exception is SocketException && 
                    (exception as SocketException).ErrorCode == 10004)
                {
                    return;
                }
                ExceptionProcess.Instance.ThrowException(
                            Resources.glb_udpClient, Resources.scope_receive,
                            exception.Message, NotifyMessageType.WARNING);
            }
        }
        #endregion
    }
}
