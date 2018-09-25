using System;
using System.Net;
using System.Net.Sockets;

namespace Server.Model
{
    public class ExchangeByTCP : AbstractClient
    {
        #region Переменные
        private Socket client;
        public byte[] ReceiveBuffer { get; private set; }
        #endregion
        #region Конструктор
        public ExchangeByTCP()
        {
            ReceiveBuffer = new byte[1500];
        }
        #endregion
        #region Публичные методы
        public override void Connect(IPEndPoint remotePoint)
        {
            if (IsConnect)
                Disconnect();

            RemoteEndPoint = remotePoint;

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.ReceiveTimeout = 2000;
            client.SendTimeout   = 2000;
            client.Connect(RemoteEndPoint);
            OnStateChanged(true);
        }
        public override void Disconnect()
        {
            if (!IsConnect)
                return;

            OnStateChanged(false);
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            client = null;
        }
        public override void Transmit(byte[] data)
        {
            try
            {
                if (!client.Poll(1000, SelectMode.SelectWrite))
                {
                    throw new Exception("");
                }
                int transmitResult = client.Send(data);
            }
            catch (Exception exception)
            {   throw new Exception(exception.Message); }
        }
        public void Receive(out byte[] data, int length)
        {
            data = null;
            try
            {
                int bytes = 0;
                if (!client.IsConnected())
                {
                    ExceptionProcess.Instance.ThrowException(
                         "Клиент TCP",
                         "Прием данных",
                         "Сервер не отвечает на запрос",
                         NotifyMessageType.WARNING);
                }
                bytes = client.Receive(ReceiveBuffer, length, 0);

                if (ReceiveBuffer != null && bytes > 0)
                {
                    data = new byte[bytes];
                    Array.Copy(ReceiveBuffer, 0, data, 0, bytes);
                }
            }
            catch (Exception exception)
            {
                ExceptionProcess.Instance.ThrowException(
                           Resources.glb_tcpClient, Resources.scope_receive,
                           exception.Message, NotifyMessageType.WARNING);
            }
        }

        #endregion
    }
}
