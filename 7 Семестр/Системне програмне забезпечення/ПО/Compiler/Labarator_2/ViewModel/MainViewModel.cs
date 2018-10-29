using CompilerAPI.LexemAnalyzerModel;

using Labarator_2.Auxiliary;

using Microsoft.Win32;

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Labarator_2.ViewModel
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
        public ICommand CmdRunLexemAnalyzer
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

        #region Свойство
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

        /// <summary>
        /// Список лексем
        /// </summary>
        public ReadOnlyCollection<Lexem> LexemList { get; private set; }

        #endregion

        #region Конструктор

        public MainViewModel()
        {
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
                    Filter = "Текстовый файл (.txt) | *.txt"
                };

                if (openFileDialog.ShowDialog() == false)
                {
                    return;
                }
                FilePath = openFileDialog.FileName;

                if (string.IsNullOrEmpty(FilePath))
                {
                    MessageBox.Show("Не удалось получить путь к файлу");
                    return;
                }

                InputFile = File.ReadAllText(openFileDialog.FileName);

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
                if (string.IsNullOrEmpty(InputFile))
                {
                    MessageBox.Show("Нет данных для анализа");
                    return;
                }

                LexemParser parser = new LexemParser();

                if(parser == null)
                {   throw new ArgumentNullException(nameof(parser));    }


                LexemList = parser.GetLexems(InputFile);
                OnPropertyChanged(nameof(LexemList));
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
                FilePath = string.Empty;
                InputFile = string.Empty;

                LexemList = null;
                OnPropertyChanged(nameof(LexemList));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion
    }
}
