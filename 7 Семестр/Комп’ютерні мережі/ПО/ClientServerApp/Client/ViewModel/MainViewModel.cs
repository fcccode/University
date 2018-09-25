using Client.Auxiliary;
using Client.Model;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class MainViewModel :BindingProperty
    {
        private ICommand _connect;
        public ICommand CmdConnect
        {
            get
            {
                if(_connect == null)
                {   _connect = new ActionCommand(() => Task.Factory.StartNew(DoConnect), () => !ExModel.IsConnect);    }
                return _connect;
            }
        }

        private ICommand _disconnect;
        public ICommand CmdDisconnect
        {
            get
            {
                if (_disconnect == null)
                { _disconnect = new ActionCommand(()=>Task.Factory.StartNew(DoDisconnect), () => ExModel.IsConnect); }
                return _disconnect;
            }
        }

        private ICommand _sendData;
        public ICommand CmdSendData
        {
            get
            {
                if (_sendData == null)
                { _sendData = new ActionCommand(() => Task.Factory.StartNew(DoSendData), ()=>ExModel.IsConnect); }
                return _sendData;
            }
        }

        private string _ipAddress;
        public string IpAddress
        {
            get { return _ipAddress; }
            set
            {
                _ipAddress = value;
                OnPropertyChanged(nameof(IpAddress));
            }
        }

        private int _serverPort;
        public int ServerPort
        {
            get { return _serverPort; }
            set { _serverPort = value;
                OnPropertyChanged(nameof(ServerPort));
            }
        }

        public ExchangeData  ExData{ get; private set; }
        public ExchangeModel ExModel{ get; private set; }

        public MainViewModel()
        {
            ExData = new ExchangeData();
            ExModel = new ExchangeModel();
        }

        private void DoDisconnect()
        {
            try
            {
                if (!ExModel.IsConnect)
                { MessageBox.Show("Нет активного подключения"); return; }

                ExModel.Disconnect();
            }
            catch (Exception exception)
            {   MessageBox.Show(exception.Message); }
        }

        private void DoConnect()
        {
            try
            {
                if (ExModel.IsConnect)
                { MessageBox.Show("Активное подключение присутствует"); return; }

                if(ServerPort < 1000 || ServerPort > 65535)
                { MessageBox.Show("Указан не корректный порт сервера"); return; }

                if(string.IsNullOrEmpty(IpAddress))
                { MessageBox.Show("Введите адрес сервера"); return; }

                ExModel.Connect(IpAddress, ServerPort);
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }

        private void DoSendData()
        {
            try
            {
                if(!ExModel.IsConnect)
                { MessageBox.Show("Нет активного подключения"); return; }

                if (!ExModel.SendData(ExData.GetBytes()))
                { MessageBox.Show("Не удалось подключиться"); }
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }
    }
}
