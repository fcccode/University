using CompilerAPI.Helper;
using CompilerAPI.Interface;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CompilerAPI.LexemItentifierModel
{
    /// <summary>
    /// Таблица идентификаторов
    /// </summary>
    public class SimpleIndentityTable : BindingProperty, IIdentityFeature
    {
        #region Переменные
        
        /// <summary>
        /// Максимальная длина ключа
        /// </summary>
        public const uint MAX_IDENTIFY_LENGTH = 32;

        /// <summary>
        /// Внутреннее представление таблицы
        /// </summary>
        private List<IdentitifierInfo> _items;

        /// <summary>
        /// Диагностический таймеры
        /// </summary>
        private readonly Stopwatch timer;
        #endregion

        #region Свойства

        /// <summary>
        /// Таблица элементов, только для чтения
        /// </summary>
        public ReadOnlyCollection<IdentitifierInfo> Items { get { return _items.AsReadOnly(); } }

        /// <summary>
        /// Общее количество операций 
        /// </summary>
        private int _totalOperationCount;
        public int TotalOperationCount
        {
            get { return _totalOperationCount; }
            set
            {
                _totalOperationCount = value;
                OnPropertyChanged(nameof(TotalOperationCount));
            }
        }

        /// <summary>
        /// Среднее количество операций 
        /// </summary>
        private int _middleOperationCount;
        public int MiddleOperationCount
        {
            get { return _middleOperationCount; }
            set
            {
                _middleOperationCount = value;
                OnPropertyChanged(nameof(MiddleOperationCount));
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
        public SimpleIndentityTable()
        {
            _items = new List<IdentitifierInfo>();
            timer = new Stopwatch();
        }

        #endregion

        #region Реализация интерфейса

        /// <summary>
        /// Добавление элемента в таблицу
        /// </summary>
        /// <param name="value"></param>
        public void AddItem(IdentitifierInfo value)
        {
            if (value == null)
            { throw new ArgumentNullException(nameof(value)); }

            if (string.IsNullOrEmpty(value.ItemName))
            { throw new ArgumentNullException(nameof(value.ItemName)); }

            if (value.ItemName.Length > MAX_IDENTIFY_LENGTH)
            { throw new ArgumentNullException(@"Длина ключа превышает лимит в {MAX_IDENTIFY_LENGTH}"); }

            foreach (IdentitifierInfo item in _items)
            {
                TotalOperationCount++;
                if (item.ItemName == value.ItemName)
                { throw new Exception("Элемент с таким ключом присутствует" + value.ItemName); }
            }

            _items.Add(value);

        }

        /// <summary>
        /// Поиск элемента в таблице по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>Найденный объект или null</returns>
        public IdentitifierInfo FindItem(string key)
        {

            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (_items == null)
            { throw new ArgumentNullException(nameof(_items)); }


            foreach (IdentitifierInfo item in _items)
            {
                TotalOperationCount++;
                if (item.ItemName == key)
                {   return item; }
            }

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

            foreach (IdentitifierInfo item in _items)
            {
                TotalOperationCount++;
                if (item.ItemName == key)
                {   return _items.Remove(item); }
            }

            return false;
        }

        /// <summary>
        /// Очистка всей таблицы
        /// </summary>
        public void ClearItems()
        {
            if (_items != null)
            {
                _items.Clear();
                //OperationCount++;
                //List<IdentityInfo> temp = new List<IdentityInfo>(_items);
                //foreach (IdentityInfo item in temp)
                //{
                //    OperationCount++;
                //    _items.Remove(item);
                //}
            }

        }
        #endregion
    }
}
