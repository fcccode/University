using CompilerAPI.Enum;

namespace CompilerAPI.Indetity
{
    /// <summary>
    /// Информация о идентификаторе
    /// </summary>
    public class IdentityInfo
    {
        public string ItemName { get; private set; }
        public object ItemValue { get; set; }
        public IdentityType ItemType {get; private set;}
       
        public IdentityInfo(string key, IdentityType type)
        {
            ItemName = key;
            ItemType = type;
        }
    }
}
