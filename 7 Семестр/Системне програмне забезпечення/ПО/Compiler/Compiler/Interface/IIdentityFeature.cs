using Compiler.Indetity;

namespace Compiler.Interface
{
    /// <summary>
    /// Интерфейс таблицы идентификаторов
    /// </summary>
    public interface IIdentityFeature
    {

        #region Свойства
        string ElapsedTime {get;set; }
        int OperationCount { get; set; }
        #endregion

        #region Функционал
        void AddItem(IdentityInfo value);
        IdentityInfo FindItem(string key);
        bool RemoveItem(string key);
        void ClearItems(); 
        #endregion
    }
}
