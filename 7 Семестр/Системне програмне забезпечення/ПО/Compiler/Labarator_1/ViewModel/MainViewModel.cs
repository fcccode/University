using CompilerAPI.Enum;
using CompilerAPI.Interface;
using CompilerAPI.LexemItentifierModel;

using Labarator_1.Auxiliary;

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

        #region Переменные

        private readonly char[] separator;

        #endregion

        #region Свойство

        private HashIdentityTable _hashtable;
        public IIdentityFeature HashTableWrapper
        {
            get { return _hashtable; }
        }

        private SimpleIndentityTable _simpleTable;
        public IIdentityFeature SimpleTableWrapper
        {
            get { return _simpleTable; }
        }

        private string _searchItem;
        public string SearchItem
        {
            get { return _searchItem; }
            set
            {
                _searchItem = value;
                OnPropertyChanged(nameof(SearchItem));
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

        private List<string> _identifyList;
        public ReadOnlyCollection<string> IdentifyList
        {
            get { return _identifyList.AsReadOnly(); }
        }

        private bool _isHashTableFindItem;
        public bool IsHashTableFindItem
        {
            get { return _isHashTableFindItem; }
            set
            {
                _isHashTableFindItem = value;
                OnPropertyChanged(nameof(IsHashTableFindItem));
            }
        }

        private bool _isSimpleTableFindItem;
        public bool IsSimpleTableFindItem
        {
            get { return _isSimpleTableFindItem; }
            set
            {
                _isSimpleTableFindItem = value;
                OnPropertyChanged(nameof(IsSimpleTableFindItem));
            }
        }
       
        #endregion

        #region Конструктор

        public MainViewModel()
        {

            _hashtable = new HashIdentityTable();
            _simpleTable = new SimpleIndentityTable();
            _identifyList = new List<string>();
            separator = new char[] { ' ', '\r', '\0', ';', '=' };
        }
       
        #endregion

        #region Методы

        /// <summary>
        /// Разбить входную строку на лексемы
        /// </summary>
        /// <param name="file"></param>
        private void ParseInputLiter(string file)
        {
            if (string.IsNullOrEmpty(file))
            { throw new ArgumentNullException(nameof(file)); }

            var temp = file.Split(separator).ToList();
            foreach (string identity in temp)
            {
                
                string t = identity.Replace('\n', ' ');
                if (string.IsNullOrEmpty(t) || t == " " )
                    continue;
                _identifyList.Add(t);
            }
            OnPropertyChanged(nameof(IdentifyList));
        }

        /// <summary>
        /// Создание простой таблицы идентификаторов
        /// </summary>
        private void CreateSimpleIdentityTable()
        {
            if (_simpleTable == null)
            { throw new ArgumentNullException(nameof(_simpleTable)); }

            if (_identifyList == null)
            { throw new ArgumentNullException(nameof(_identifyList)); }

            IdentitifierInfo item = null;
            SimpleTableWrapper.TotalOperationCount = 0;
            foreach (string identity in IdentifyList)
            {
                if (string.IsNullOrEmpty(identity))
                    continue;

                item = new IdentitifierInfo(identity, IdentifierType.VARIABLE)
                {
                    ItemValue = string.Empty
                };

                if (item != null)
                    SimpleTableWrapper.AddItem(item);
            }
            SimpleTableWrapper.MiddleOperationCount = SimpleTableWrapper.TotalOperationCount / SimpleTableWrapper.Items.Count;
            OnPropertyChanged(nameof(SimpleTableWrapper));
        }

        /// <summary>
        /// Создание таблицы на основе хеш функций
        /// </summary>
        private void CreateHashIdentityTable()
        {
            if (_hashtable == null)
            { throw new ArgumentNullException(nameof(_hashtable)); }

            if (_identifyList == null)
            { throw new ArgumentNullException(nameof(_identifyList)); }

            IdentitifierInfo item = null;
            HashTableWrapper.TotalOperationCount = 0;
            foreach (string identity in IdentifyList)
            {
                if (string.IsNullOrEmpty(identity))
                    continue;

                item = new IdentitifierInfo(identity, IdentifierType.VARIABLE)
                {
                    ItemValue = string.Empty
                };

                if (item != null)
                    HashTableWrapper.AddItem(item);
            }
            HashTableWrapper.MiddleOperationCount = HashTableWrapper.TotalOperationCount / HashTableWrapper.Items.Count;
            OnPropertyChanged(nameof(HashTableWrapper));
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
                
                if (openFileDialog.ShowDialog() == true)
                {
                    FilePath = openFileDialog.FileName;

                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        string file = File.ReadAllText(openFileDialog.FileName);

                        if (string.IsNullOrEmpty(file))
                        { throw new ArgumentNullException("Не удалось загрузить файл"); }

                        ParseInputLiter(file);
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
                if (IdentifyList == null || IdentifyList.Count <= 0)
                {
                    MessageBox.Show("Не загружен файл");
                    return;
                }

                CreateSimpleIdentityTable();
                CreateHashIdentityTable();
                MessageBox.Show("Таблицы созданы");
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
                if (string.IsNullOrEmpty(SearchItem))
                {
                    MessageBox.Show("Введите ключ для поиска");
                    return;
                }

                if (_hashtable == null || _simpleTable == null)
                { throw new ArgumentNullException(nameof(HashTableWrapper) + " или " + nameof(SimpleTableWrapper)); }

                if (_hashtable.Items.Count <= 0 || _simpleTable.Items.Count <= 0)
                {
                    MessageBox.Show("Таблицы еще не содержат элементов, Создайте таблицы!");
                }

                HashTableWrapper.TotalOperationCount = 0;
                HashTableWrapper.MiddleOperationCount = 0;
                IsHashTableFindItem = (HashTableWrapper.FindItem(SearchItem) == null) ? false : true;

                SimpleTableWrapper.TotalOperationCount = 0;
                SimpleTableWrapper.MiddleOperationCount = 0;
                IsSimpleTableFindItem = (SimpleTableWrapper.FindItem(SearchItem) == null) ? false : true;
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
                if(IdentifyList != null)
                {
                    _identifyList.Clear();
                    OnPropertyChanged(nameof(IdentifyList));
                }

                if(_hashtable != null)
                {
                    _hashtable.ClearItems();
                    OnPropertyChanged(nameof(HashTableWrapper));
                }

                if (_simpleTable != null)
                {
                    _simpleTable.ClearItems();
                    OnPropertyChanged(nameof(SimpleTableWrapper));
                }

                FilePath = string.Empty;
                SearchItem = string.Empty;
                IsHashTableFindItem = false;
                IsSimpleTableFindItem = false;

                HashTableWrapper.TotalOperationCount = 0;
                HashTableWrapper.MiddleOperationCount = 0;

                SimpleTableWrapper.TotalOperationCount = 0;
                SimpleTableWrapper.MiddleOperationCount = 0;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion
    }
}
