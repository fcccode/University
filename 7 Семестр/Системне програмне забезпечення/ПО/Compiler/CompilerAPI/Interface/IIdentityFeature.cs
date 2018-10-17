using CompilerAPI.Indetity;
using System.Collections.ObjectModel;

namespace CompilerAPI.Interface
{
    /// <summary>
    /// Интерфейс таблицы идентификаторов
    /// </summary>
    public interface IIdentityFeature
    {

        #region Свойства

        string ElapsedTime { get; set; }
        int TotalOperationCount { get; set; }
        int MiddleOperationCount { get; set; }
        ReadOnlyCollection<IdentityInfo> Items { get; }
        #endregion

        #region Функционал
        void AddItem(IdentityInfo value);
        IdentityInfo FindItem(string key);
        bool RemoveItem(string key);
        void ClearItems();
        #endregion
    }
}
