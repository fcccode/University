using CompilerAPI.LexemItentifierModel;
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
        ReadOnlyCollection<IdentitifierInfo> Items { get; }
        #endregion

        #region Функционал
        void AddItem(IdentitifierInfo value);
        IdentitifierInfo FindItem(string key);
        bool RemoveItem(string key);
        void ClearItems();
        #endregion
    }
}
