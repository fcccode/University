using Server.Auxiliary;
using Server.Model;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Server.ViewModel
{
    public class MainViewModel :BindingProperty
    {
        private ICommand _runServer;
        public ICommand CmdRunServer
        {
            get
            {
                if (_runServer == null)
                { _runServer = new ActionCommand(() => Task.Factory.StartNew(DoRunServer), () => !ServerModel.IsConnect); }
                return _runServer;
            }
        }

        private ICommand _stopServer;
        public ICommand CmdStopServer
        {
            get
            {
                if (_stopServer == null)
                { _stopServer = new ActionCommand(() => Task.Factory.StartNew(DoStopServer), ()=>ServerModel.IsConnect); }
                return _stopServer;
            }
        }

        private ICommand _setInterval;
        public ICommand CmdSetInterval
        {
            get
            {
                if (_setInterval == null)
                { _setInterval = new ActionCommand(() => Task.Factory.StartNew(DoSetInterval), () => ServerModel.IsConnect); }
                return _setInterval;
            }
        }

        private ICommand _clearConsole;
        public ICommand CmdClearConsole
        {
            get
            {
                if (_clearConsole == null)
                { _clearConsole = new ActionCommand(() => Task.Factory.StartNew(DoClearConsole)); }
                return _clearConsole;
            }
        }

        private int _interval;
        public int Interval
        {
            get { return _interval; }
            set
            {
                _interval = value;
                OnPropertyChanged(nameof(Interval));
            }
        }

        public ExchangeModel ServerModel { get; private set; }

        public MainViewModel()
        {
            Interval = 10;
            ServerModel = new ExchangeModel();
        }

        private void DoStopServer()
        {
            try
            {
                if(!ServerModel.IsConnect)
                {
                    MessageBox.Show("Сервер не запущен");
                    return;
                }

                ServerModel.StopServer();
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }

        private void DoRunServer()
        {
            try
            {
                if (ServerModel.IsConnect)
                {
                    MessageBox.Show("Сервер уже запущен");
                    return;
                }

                ServerModel.RunServer();
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }

        private void DoSetInterval()
        {
            try
            {
                if (!ServerModel.IsConnect)
                {
                    MessageBox.Show("Сервер не запущен");
                    return;
                }


            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }


        private void DoClearConsole()
        {
            try
            {

            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }
    }
}
