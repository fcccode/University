using Server.Auxiliary;
using System.Collections.ObjectModel;

namespace Server.Model
{
    public class CustomServer :BindingProperty
    {
        #region Переменные

        #endregion

        #region Свойства

        /// <summary>
        /// Список клиентов сервера
        /// </summary>
        private ObservableCollection<CustomClient> _clientList;
        private ObservableCollection<CustomClient> ClientList
        {
            get { return _clientList; }
            set
            {
                _clientList = value;
                OnPropertyChanged(nameof(ClientList));
            }
        }

        public string ResponseMessage { get; private set; }
        public string ErrorMessage { get; private set; }
        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="setting">настройки для сервера</param>
        public CustomServer(ServerSetting setting)
        {

        }
        #endregion

        #region Приватные методы

        #endregion

        #region Публичные методы

        /// <summary>
        /// Запуск сервера
        /// </summary>
        /// <returns></returns>
        public bool StartServer()
        {
            return true;
        }

        /// <summary>
        /// Остановка сервера
        /// </summary>
        /// <returns></returns>
        public bool StopServer()
        {
            return true;
        }

        /// <summary>
        /// Изменение параметров сервера
        /// </summary>
        /// <returns></returns>
        public bool ChangeServerSetting(ServerSetting setting)
        {
            return true;
        }

        #endregion
    }
}
