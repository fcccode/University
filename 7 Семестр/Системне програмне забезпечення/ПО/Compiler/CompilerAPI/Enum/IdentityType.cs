using System.ComponentModel;

namespace CompilerAPI.Enum
{
    public enum IdentityType
    {
        [Description("Переменная")]
        VARIABLE,
        [Description("Константа")]
        CONSTANT
    }
}
