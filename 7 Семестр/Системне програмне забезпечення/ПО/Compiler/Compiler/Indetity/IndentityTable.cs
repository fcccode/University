using Compiler.Helper;
using Compiler.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Compiler.Indetity
{
    /// <summary>
    /// Таблица идентификаторов
    /// </summary>
    public class IndentityTable : BindingProperty, IIdentityFeature
    {
        #region Переменные
        
        /// <summary>
        /// Максимальная длина ключа
        /// </summary>
        public const uint MAX_IDENTIFY_LENGTH = 32;

        /// <summary>
        /// Внутреннее представление таблицы
        /// </summary>
        private List<IdentityInfo> _items;

        /// <summary>
        /// Диагностический таймеры
        /// </summary>
        private Stopwatch timer;
        #endregion

        #region Свойства

        /// <summary>
        /// Таблица элементов, только для чтения
        /// </summary>
        public IReadOnlyCollection<IdentityInfo> Items { get { return _items.AsReadOnly(); } }

        /// <summary>
        /// Количество операций 
        /// </summary>
        private int _operationCount;
        public int OperationCount
        {
            get { return _operationCount; }
            set
            {
                _operationCount = value;
                OnPropertyChanged(nameof(OperationCount));
            }
        }

        /// <summary>
        /// Время затраченное на выполнение одной из операций
        /// </summary>
        private string  _elapseTime;
        public string  ElapsedTime
        {
            get { return _elapseTime; }
            set
            {
                _elapseTime = value;
                OnPropertyChanged(nameof(ElapsedTime));
            }
        }


        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public IndentityTable()
        {
            _items = new List<IdentityInfo>();
            timer = new Stopwatch();
        }

        #endregion

        #region Реализация интерфейса

        /// <summary>
        /// Добавление элемента в таблицу
        /// </summary>
        /// <param name="value"></param>
        public void AddItem(IdentityInfo value)
        {
            if (value == null)
            { throw new ArgumentNullException(nameof(value)); }

            if (string.IsNullOrEmpty(value.Key))
            { throw new ArgumentNullException(nameof(value.Key)); }

            if (value.Key.Length > MAX_IDENTIFY_LENGTH)
            { throw new ArgumentNullException(@"Длина ключа превышает лимит в {MAX_IDENTIFY_LENGTH}"); }

            timer.Restart();
            OperationCount = 0; 

            foreach (IdentityInfo item in _items)
            {
                OperationCount++;
                if (item.Key == value.Key)
                { throw new Exception("Элемент с таким ключом присутствует"); }
            }

            _items.Add(value);
            OperationCount++;

            timer.Stop();
            ElapsedTime = timer.Elapsed.ToString();

        }

        /// <summary>
        /// Поиск элемента в таблице по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>Найденный объект или null</returns>
        public IdentityInfo FindItem(string key)
        {

            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (_items == null)
            { throw new ArgumentNullException(nameof(_items)); }

            timer.Restart();
            OperationCount = 0;
            foreach (IdentityInfo item in _items)
            {
                OperationCount++;
                if (item.Key == key)
                {   return item; }
            }

            timer.Stop();
            ElapsedTime = timer.Elapsed.ToString();
            return null;
        }

        /// <summary>
        /// Удаление элемента по ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RemoveItem(string key)
        {
            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (_items == null)
            { throw new ArgumentNullException(nameof(_items)); }

            timer.Restart();
            OperationCount = 0;

            foreach (IdentityInfo item in _items)
            {
                OperationCount++;
                if (item.Key == key)
                {   return _items.Remove(item); }
            }

            timer.Stop();
            ElapsedTime = timer.Elapsed.ToString();
            return false;
        }

        /// <summary>
        /// Очистка всей таблицы
        /// </summary>
        public void ClearItems()
        {
            timer.Restart();
            OperationCount = 0;

            if (_items != null)
            {
                //_items.Clear();
                OperationCount++;
                List<IdentityInfo> temp = new List<IdentityInfo>(_items);
                foreach (IdentityInfo item in temp)
                {
                    OperationCount++;
                    _items.Remove(item);
                }
            }

            timer.Stop();
            ElapsedTime = timer.Elapsed.ToString();
        }
        #endregion
    }
}
