using System;
using System.Net;
using System.Net.Sockets;
using Client.Auxiliary;

namespace Client.Model
{
    public class ExchangeModel: AbstractClient
    {
        private Socket client;
        public ExchangeModel(){   }
        public bool Connect(string ipAddress, int port)
        {
            if (IsConnect)
            { Disconnect(); }

            
            RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(RemoteEndPoint);
            client.ReceiveTimeout = 2000;
            client.SendTimeout = 2000;
            client.SetKeepAlive(360000, 1000);
            OnStateChanged(true);
            return true;
        }
        public void Disconnect()
        {
            if (!IsConnect)
                return;

            OnStateChanged(false);
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            client = null;
        }
        public bool SendData(byte[] data)
        {
            if (!client.Poll(1000, SelectMode.SelectWrite))
            {
                throw new Exception("Время ожидания канала связи");
            }
            return (client.Send(data)> 0)? true: false;
        }
    }
}
