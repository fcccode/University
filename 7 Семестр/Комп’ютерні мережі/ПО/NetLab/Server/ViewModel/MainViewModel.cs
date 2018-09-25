using Server.Auxiliary;
using Server.Model;
using Server.View;
using System;
using System.Windows.Input;

namespace Server.ViewModel
{
    public class MainViewModel : BindingProperty
    {
        #region Команды

        private ICommand _startServer;
        public ICommand CmdStartServer
        {
            get
            {
                if (_startServer == null)
                { _startServer = new ActionCommand(DoStartServer); }

                return _startServer;
            }
        }

        private ICommand _stopServer;
        public ICommand CmdStopServer
        {
            get
            {
                if (_stopServer == null)
                { _stopServer = new ActionCommand(DoStopServer); }

                return _stopServer;
            }
        }

        private ICommand _settingServer;
        public ICommand CmdSettingServer
        {
            get
            {
                if (_settingServer == null)
                { _settingServer = new ActionCommand(DoSettingServer); }

                return _settingServer;
            }
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Настройки сервера
        /// </summary>
        private ServerSetting _settings;
        public ServerSetting DefaultSettings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                OnPropertyChanged(nameof(DefaultSettings));
            }
        }

        /// <summary>
        /// Модель всплывающих сообщений
        /// </summary>
        public ToastViewModel Notificate { get; private set; }
        
        /// <summary>
        /// Модель сервера
        /// </summary>
        public CustomServer ServerModel { get; private set; }
        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// 
        public MainViewModel()
        {
            DefaultSettings = new ServerSetting();
            Notificate = new ToastViewModel();
            ServerModel = new CustomServer(DefaultSettings);
        }
        #endregion

        #region Методы

        #endregion

        #region Обработчики команд

        /// <summary>
        /// Запуск сервера
        /// </summary>
        /// <param name="obj"></param>
        private void DoStartServer(object obj)
        {
            try
            {
                if (ServerModel == null)
                { return; }

                bool result = ServerModel.StartServer();

                if (result)
                { Notificate.ShowSuccess(ServerModel.ResponseMessage); }
                else
                { Notificate.ShowError(ServerModel.ErrorMessage); }
            }
            catch(Exception exception)
            {   Notificate.ShowError(exception.Message);    }
        }

        /// <summary>
        /// Остановка сервера
        /// </summary>
        /// <param name="obj"></param>
        private void DoStopServer(object obj)
        {
            try
            {
                if (ServerModel == null)
                { return; }

                bool result = ServerModel.StopServer();

                if (result)
                { Notificate.ShowSuccess(ServerModel.ResponseMessage); }
                else
                { Notificate.ShowError(ServerModel.ErrorMessage); }
            }
            catch (Exception exception)
            { Notificate.ShowError(exception.Message); }
        }

        /// <summary>
        /// Настройки сервера
        /// </summary>
        /// <param name="obj"></param>
        private void DoSettingServer(object obj)
        {
            ServerSettingView view = new ServerSettingView
            {   DataContext = DefaultSettings, };
            view.ShowDialog();

            if (DefaultSettings == null)
            { Notificate.ShowError(""); }

            if (ServerModel == null)
            { Notificate.ShowError(""); }

            ServerModel.ChangeServerSetting(DefaultSettings);
        }


        #endregion

        #region Обработчики событий

        #endregion
    }
}

