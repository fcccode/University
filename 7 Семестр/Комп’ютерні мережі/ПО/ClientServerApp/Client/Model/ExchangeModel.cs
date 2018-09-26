using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Client.Auxiliary;

namespace Client.Model
{
    public class ExchangeModel : AbstractClient
    {
        private Socket client;
        public ExchangeModel() { }
        public bool Connect(string ipAddress, int port)
        {
            if (IsConnect)
            { Disconnect(); }


            RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(RemoteEndPoint);
            OnStateChanged(true);
            Task.Factory.StartNew(ReceiveData);
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

        public void ReceiveData()
        {
            try
            {
                while (IsConnect)
                {
                    if (!client.Poll(1000, SelectMode.SelectWrite))
                    {
                        throw new Exception("Обрыв связи");
                    }
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                Console.WriteLine(ex.Message);
            }
        }

        public bool SendData(byte[] data)
        {
            try
            {
                if (!client.Poll(1000, SelectMode.SelectWrite))
                {
                    throw new Exception("Время ожидания канала связи");
                }
                return (client.Send(Encoding.UTF8.GetBytes("Hello")) > 0) ? true : false;
            }
            catch (Exception ex)
            {
                Disconnect();
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
