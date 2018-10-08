using Labarator_1.Auxiliary;
using Labarator_1.Auxiliary.Interfaces;
using Labarator_1.Model;
using System;
using System.Windows.Input;

namespace Labarator_1.ViewModel
{
    public class MainViewModel : BindingProperty
    {
        #region Команды

        /// <summary>
        /// Команда выбора файл в проводнике
        /// </summary>
        private ICommand selectFile;
        public ICommand CmdSelectFile
        {
            get
            {
                if (selectFile == null)
                    selectFile = new ActionCommand(DoLoadFile);
                return selectFile;
            }
        }

        /// <summary>
        /// Запуск анализатора
        /// </summary>
        private ICommand runAnalyze;
        public ICommand CmdRunAnalyze
        {
            get
            {
                if (runAnalyze == null)
                    runAnalyze = new ActionCommand(DoRunAnalizy);
                return runAnalyze;
            }
        }

        /// <summary>
        /// Поиск идентификатора
        /// </summary>
        private ICommand findIdentify;
        public ICommand CmdFindIdentify
        {
            get
            {
                if (findIdentify == null)
                    findIdentify = new ActionCommand(DoFindIdentify);
                return findIdentify;
            }
        }


        /// <summary>
        /// Сброс все значений
        /// </summary>
        private ICommand resetProperty;
        public ICommand CmdResetProperty
        {
            get
            {
                if (resetProperty == null)
                    resetProperty = new ActionCommand(DoResetProperty);
                return resetProperty;
            }
        }

        #endregion

        #region Свойства

        public IIdentifyModel FirstModel { get; private set; } 
        public IIdentifyModel SecondModel { get; private set; } 
        
        #endregion

        #region Конструктор

        public MainViewModel()
        {
            FirstModel = new FirstMethod();
            SecondModel = new SecondMethod();
        }
        #endregion

        #region Методы

        #endregion

        #region Обработчики команд

        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="obj"></param>
        private void DoLoadFile(object obj)
        {
            
        }


        /// <summary>
        /// Запуск анализа
        /// </summary>
        /// <param name="obj"></param>
        private void DoRunAnalizy(object obj)
        {
            
        }

        /// <summary>
        /// Поиск идентификатора
        /// </summary>
        /// <param name="obj"></param>
        private void DoFindIdentify(object obj)
        {
            
        }

        /// <summary>
        /// Сброс предыдущих значений
        /// </summary>
        /// <param name="obj"></param>
        private void DoResetProperty(object obj)
        {
            
        }
        #endregion
    }
}
