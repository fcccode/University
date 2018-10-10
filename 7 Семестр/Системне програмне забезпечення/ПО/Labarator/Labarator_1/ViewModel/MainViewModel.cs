using Labarator_1.Auxiliary;
using Labarator_1.Auxiliary.Interfaces;
using Labarator_1.Model;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
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
        private Stopwatch diagnosticTimer;
        public SimpleTable SecondModel { get; private set; }
        public Hashtable FirstModel { get; private set; }
        public StringBuilder Liters { get; private set; }

        private string _simpleTableGenerateTime;
        public string SimpleTableGenerateTime
        {
            get { return _simpleTableGenerateTime; }
            set
            {
                _simpleTableGenerateTime = value;
                OnPropertyChanged(nameof(SimpleTableGenerateTime));
            }
        }

        private string _hashTableGenerateTime;
        public string HashTableGenerateTime
        {
            get { return _hashTableGenerateTime; }
            set
            {
                _hashTableGenerateTime = value;
                OnPropertyChanged(nameof(HashTableGenerateTime));
            }
        }

        #endregion

        #region Конструктор

        public MainViewModel()
        {
            SecondModel = new SimpleTable();
            FirstModel = new Hashtable();
            Liters = new StringBuilder();
            diagnosticTimer = new Stopwatch();
        }
        #endregion

        #region Методы

        /// <summary>
        /// Разбить входную строку на лексемы
        /// </summary>
        /// <param name="file"></param>
        private void ParseInputLiter(string file)
        {

        }

        /// <summary>
        /// Создание простой таблицы идентификаторов
        /// </summary>
        private void CreateSimpleIdentityTable()
        {
            diagnosticTimer.Reset();
            diagnosticTimer.Start();

            if (Liters == null)
            { throw new ArgumentNullException(nameof(Liters)); }




            diagnosticTimer.Stop();
            SimpleTableGenerateTime = diagnosticTimer.Elapsed.ToString();
        }

        /// <summary>
        /// Создание таблицы на основе хеш функций
        /// </summary>
        private void  CreateHashIdentityTable()
        {
            diagnosticTimer.Reset();
            diagnosticTimer.Start();

            if (Liters == null)
            { throw new ArgumentNullException(nameof(Liters)); }




            diagnosticTimer.Stop();
            HashTableGenerateTime = diagnosticTimer.Elapsed.ToString();
        }

        #endregion

        #region Обработчики команд

        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="obj"></param>
        private void DoLoadFile(object obj)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Пользовательский бинарный файл (.ask) | *.ask"
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    string file = File.ReadAllText(openFileDialog.FileName);

                    if (string.IsNullOrEmpty(file))
                    { throw new ArgumentNullException("Не удалось загрузить файл"); }

                    ParseInputLiter(file);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Запуск анализа
        /// </summary>
        /// <param name="obj"></param>
        private void DoRunAnalizy(object obj)
        {
            try
            {
                CreateSimpleIdentityTable();
                CreateHashIdentityTable();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Поиск идентификатора
        /// </summary>
        /// <param name="obj"></param>
        private void DoFindIdentify(object obj)
        {
            try
            {

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Сброс предыдущих значений
        /// </summary>
        /// <param name="obj"></param>
        private void DoResetProperty(object obj)
        {
            try
            {

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion
    }
}
