using System.Net;
using System.Net.Sockets;

namespace Server.Model
{
    public class ExchangeModel: AbstractClient
    {
        private string _serverInfo;
        public string ServerInfo
        {
            get { return _serverInfo; }
            set
            {
                _serverInfo = value;
                OnPropertyChanged(nameof(ServerInfo));
            }
        }


        private TcpListener server;

        public ExchangeModel()
        {
            RemoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            ServerInfo = RemoteEndPoint.ToString();
        }

        public void RunServer()
        {
            server = new TcpListener(RemoteEndPoint);
            server.Start();
            var client = server.AcceptSocket();
        }

        public void StopServer()
        {
            if (server == null || !IsConnect)
            { return; }

            server.Stop();
        }

        public void ReceiveData()
        {

        }

        public void TransmitData(byte[] data)
        {

        }
    }
}
