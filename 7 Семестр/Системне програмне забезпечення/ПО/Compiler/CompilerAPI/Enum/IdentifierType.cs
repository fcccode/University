using System.ComponentModel;

namespace CompilerAPI.Enum
{
    public enum IdentifierType
    {
        [Description("Переменная")]
        VARIABLE,
        [Description("Константа")]
        CONSTANT
    }
}
