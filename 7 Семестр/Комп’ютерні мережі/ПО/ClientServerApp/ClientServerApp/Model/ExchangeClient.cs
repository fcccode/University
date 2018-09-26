using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server.Model
{
    public class ExchangeClient : AbstractClient
    {
        private Socket client;
        public string ClientInfo { get; private set; }

        public ExchangeClient(Socket client)
        {
            this.client = client;
            RemoteEndPoint = (IPEndPoint)client.RemoteEndPoint;
            ClientInfo = client.RemoteEndPoint.ToString();
            OnStateChanged(true);
            Task.Factory.StartNew(ReceiveData);
        }

        public void ReceiveData()
        {
            try
            {
                byte[] temp = null;
                List<byte> list = new List<byte>();
                while (IsConnect)
                {
                    while (client.Available > 0)
                    {
                        temp = new byte[client.Available];
                        client.Receive(temp);
                        
                        if(temp.Length == 4 && BitConverter.ToInt32(temp,0) == 1234)
                        {
                            IsConnect = true;
                            continue;
                        }
                        OnDataReceive(temp);
                        temp = null;

                    }
                }
            }
            catch (Exception exception)
            { Console.WriteLine(exception.Message); }
        }

        public string UpdateState()
        {
            try
            {
                client.Send(new byte[10]);
                if (client.Connected)
                { return ClientInfo + " Онлайн " + Environment.NewLine; }
                return ClientInfo + " Офлайн " + Environment.NewLine;
            }
            catch (Exception ex)
            { return ClientInfo + " Офлайн " + Environment.NewLine; ; }
        }

        public void Disconnect()
        {
            if (client != null)
            {
                OnStateChanged(false);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client = null;
            }
        }
    }
}
