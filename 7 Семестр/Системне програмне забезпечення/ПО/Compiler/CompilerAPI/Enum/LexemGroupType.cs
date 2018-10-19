using System.ComponentModel;

namespace CompilerAPI.Enum
{
    /// <summary>
    /// Атомы языка
    /// </summary>
    public enum LexemGroupType
    {
        [Description("Ключевое слово")]
        KEYWORD,
        [Description("Идентификатор")]
        IDENTIFIER,
        [Description("Разделитель")]
        SEPARATOR,
        [Description("Конец потока")]
        END_OF_SEQUENCE
    }
}
