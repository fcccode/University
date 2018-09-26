using Server.Auxiliary;
using Server.Model;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

        private string _consolepanel;
        public string ConsolePanel
        {
            get { return _consolepanel; }
            set
            {
                _consolepanel = value;
                OnPropertyChanged(nameof(ConsolePanel));
            }
        }

        public ExchangeModel ServerModel { get; private set; }
        private System.Timers.Timer timer;
        public MainViewModel()
        {
            Interval = 1000;
            ServerModel = new ExchangeModel();
            ServerModel.DataReceiveEvent += ReceiveMessage;
            timer = new System.Timers.Timer(Interval);
            timer.Elapsed += UpdateState;
        }

        private void ReceiveMessage(object sender, PackageReceiveEvent e)
        {
            ConsolePanel += Encoding.UTF8.GetString(e.Data) + Environment.NewLine;
        }

        private void UpdateState(object sender, ElapsedEventArgs e)
        {
            try
            {
                ServerModel.UpdateState(out string message);
               // string message = DateTime.Now.ToLongDateString() + Environment.NewLine;
                ConsolePanel += message;
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
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
                timer.Stop();
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
                timer.Start();
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

                timer.Stop();
                timer.Interval = Interval;
                timer.Start();

            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }


        private void DoClearConsole()
        {
            try
            {
                ConsolePanel = string.Empty;
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message); }
        }
    }
}
