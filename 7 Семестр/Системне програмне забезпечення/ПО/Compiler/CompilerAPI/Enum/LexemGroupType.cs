using System.ComponentModel;

namespace CompilerAPI.Enum
{
    /// <summary>
    /// Атомы языка
    /// </summary>
    public enum LexemGroupType
    {
        [Description("Ключевые слова")]
        KEYWORD,
        [Description("Идентификаторы")]
        IDENTIFIER,
        [Description("Разделители")]
        SEPARATOR,
        [Description("Конец потока")]
        END_OF_SEQUENCE
    }
}
