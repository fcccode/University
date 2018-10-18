using CompilerAPI.Enum;
using CompilerAPI.Indetity;
using CompilerAPI.Interface;

using Labarator_2.Auxiliary;

using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Labarator_1.ViewModel
{
    public class MainViewModel :BindingProperty
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

        #region Переменные

        private readonly char[] separator;

        #endregion

        #region Свойство

        private HashIdentityTable _hashtable;
        public IIdentityFeature HashTableWrapper
        {
            get { return _hashtable; }
        }

        private string _inputFile;
        public string InputFile
        {
            get { return _inputFile; }
            set
            {
                _inputFile = value;
                OnPropertyChanged(nameof(InputFile));
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                OnPropertyChanged(nameof(FilePath));
            }
        }

        #endregion

        #region Конструктор

        public MainViewModel()
        {

            _hashtable = new HashIdentityTable();
            separator = new char[] { ' ', '\r', '\0', ';', '=' };
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
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Текстовый файл (.txt) | *.txt"
                };
                
                if (openFileDialog.ShowDialog() == true)
                {
                    FilePath = openFileDialog.FileName;

                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        InputFile = File.ReadAllText(openFileDialog.FileName);
                    }
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

                if(_hashtable != null)
                {
                    _hashtable.ClearItems();
                    OnPropertyChanged(nameof(HashTableWrapper));
                }


                HashTableWrapper.TotalOperationCount = 0;
                HashTableWrapper.MiddleOperationCount = 0;


                FilePath = string.Empty;
                InputFile = string.Empty;
         


      
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion
    }
}
