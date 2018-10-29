using CompilerAPI.Enum;

namespace CompilerAPI.LexemItentifierModel
{
    /// <summary>
    /// Структура идентификатора
    /// </summary>
    public class IdentitifierInfo
    {
        public string ItemName { get; private set; }
        public object ItemValue { get; set; }
        public IdentifierType ItemType {get; private set;}
       
        public IdentitifierInfo(string key, IdentifierType type)
        {
            ItemName = key;
            ItemType = type;
        }
    }
}
