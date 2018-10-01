using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Server.Auxiliary;

namespace Server.Model
{
    public class ExchangeModel: AbstractClient
    {
        
        public List<ExchangeClient> ClientList { get; private set; }

        private object syncObject = new object();

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
            RemoteEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.1"), 4000);
            ServerInfo = RemoteEndPoint.ToString();
            ClientList = new List<ExchangeClient>();
        }

        public void RunServer()
        {
            server = new TcpListener(RemoteEndPoint);
            server.Start();
            OnStateChanged(true);
            Task.Factory.StartNew(AcceptConnection);
        }

        public void StopServer()
        {
            if (server == null || !IsConnect)
            { return; }
            OnStateChanged(false);

            foreach(ExchangeClient client in ClientList)
            {
                client.Disconnect();
            }
            ClientList.Clear();
            server.Stop();
        }

        public void AcceptConnection()
        {
            try
            {
                ExchangeClient exClient = null;
                while (IsConnect)
                {
                    Socket client = server.AcceptSocket();

                    if (client == null)
                    { continue; }

                    lock (syncObject)
                    {
                        exClient = new ExchangeClient(client);
                        exClient.DataReceiveEvent += ReceiveData;
                        ClientList.Add(exClient);
                        OnDataReceive(Encoding.UTF8.GetBytes(string.Format( "Новое подключение Ip {0} Статус Online", ((IPEndPoint)client.RemoteEndPoint).Address)));
                    }
                }
            }
            catch (Exception exceprion)
            { Console.WriteLine(exceprion.Message); }
        }

        private void ReceiveData(object sender, PackageReceiveEvent e)
        {
            OnDataReceive(e.Data);
        }

        public string UpdateState()
        {
            if(ClientList.Count==0)
            {   return "Нет активных подключений"; }

            StringBuilder builder = new StringBuilder();
            builder.Append("Количество активных подключений " + ClientList.Count.ToString() + Environment.NewLine);
            foreach(ExchangeClient client in ClientList)
            {
                builder.Append(client.ClientInfo + " Статус Online " + Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
