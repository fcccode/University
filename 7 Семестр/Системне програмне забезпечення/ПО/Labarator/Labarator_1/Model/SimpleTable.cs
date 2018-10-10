using Labarator_1.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labarator_1.Model
{
    public class SimpleTable : BindingProperty
    {
        #region Поля

        public const uint MAX_IDENTIFY_LENGTH = 32;
        private List<HashItem> _items; 
        public IReadOnlyCollection<HashItem> Items { get { return _items.AsReadOnly(); } }
        #endregion

        #region Конструктор
        public SimpleTable()
        {
            _items = new List<HashItem>();
        } 
        #endregion

        #region Методы

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Insert(string key, IdentityInfo value)
        {
            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (value == null)
            { throw new ArgumentNullException(nameof(value)); }

            if (key.Length > MAX_IDENTIFY_LENGTH)
            { throw new ArgumentNullException(@"Длина ключа превышает лимит в {MAX_IDENTIFY_LENGTH}"); }

            HashItem item = _items.FirstOrDefault(i => i.Key.Equals(key));

            if (item != null)
            { throw new Exception("Элемент с таким ключом присутствует"); }

            item = new HashItem(key, value);
        }

        /// <summary>
        /// Поиск элемента
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IdentityInfo FindItem(string key)
        {
            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (key.Length > MAX_IDENTIFY_LENGTH)
            { throw new ArgumentNullException(@"Длина ключа превышает лимит в {MAX_IDENTIFY_LENGTH}"); }

            foreach (HashItem item in _items)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Удаление элемента с таблицы
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (key.Length > MAX_IDENTIFY_LENGTH)
            { throw new ArgumentNullException(@"Длина ключа превышает лимит в {MAX_IDENTIFY_LENGTH}"); }

            HashItem item = _items.FirstOrDefault(i => i.Key.Equals(key));

            if (item != null)
            {
                return _items.Remove(item);
            }

            return false;
        } 

        #endregion
    }
}
