namespace Compiler.Indetity
{
    /// <summary>
    /// Информация о идентификаторе
    /// </summary>
    public class IdentityInfo
    {
        public string Key { get; private set; }
        public IdentityInfo(string key)
        {
            Key = key;
        }
    }
}
