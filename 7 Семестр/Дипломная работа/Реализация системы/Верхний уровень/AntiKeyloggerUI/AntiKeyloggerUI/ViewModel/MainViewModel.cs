using AntiKeyloggerUI.Auxiliary;
using AntiKeyloggerUI.Models;
using AntiKeyloggerUI.Properties;
using System.Windows.Input;

namespace AntiKeyloggerUI.ViewModel
{
    public class MainViewModel :BindingProperty
    {
        #region Команды

        /// <summary>
        /// Управления окном настройки
        /// </summary>
        private ICommand _cmdSetting;
        public ICommand CmdSetting
        {
            get
            {
                if (_cmdSetting == null)
                    _cmdSetting = new ActionCommand(() =>
                    {
                        SettingWidth = (SettingWidth == 0) ? double.NaN : 0;
                        Settings.Default.SettingWidth = SettingWidth;
                        Settings.Default.Save();
                    });
                return _cmdSetting;
            }
        }

        #endregion

        #region Переменные


        #endregion

        #region Свойства

        /// <summary>
        /// Значение управления шириной окна настройки
        /// </summary>
        private double _settingWidth;
        public double SettingWidth
        {
            get { return _settingWidth; }
            set
            {
                _settingWidth = value;
                OnPropertyChanged(nameof(SettingWidth));
            }
        }

       
        /// <summary>
        /// Модель отображения пользовательских уведомлений
        /// </summary>
        public ToastViewModel Notificate { get; private set; }

        #endregion

        #region Конструктор
        public MainViewModel()
        {
            Notificate = new ToastViewModel();
        }
        #endregion

        #region Методы
      
        #endregion

        #region Обработчики команд
     
        #endregion
       
    }
}
