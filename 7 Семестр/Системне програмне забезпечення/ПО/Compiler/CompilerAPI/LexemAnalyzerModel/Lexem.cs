using CompilerAPI.Enum;

namespace CompilerAPI.LexemAnalyzerModel
{
    /// <summary>
    /// Структурная единица языка
    /// </summary>
    public class Lexem
    {
        /// <summary>
        /// Группа к которой относится лексема
        /// </summary>
        public LexemGroupType TokenType { get; set; }

        /// <summary>
        /// Значение хранимое лексемой
        /// </summary>
        public string Value { get; set; }

        public Lexem(LexemGroupType tokenType)
        {
            TokenType = tokenType;
            Value = string.Empty;
        }

        public Lexem(LexemGroupType tokenType, string value)
        {
            TokenType = tokenType;
            Value = value;
        }

        public Lexem Clone()
        {
            return new Lexem(TokenType, Value);
        }
    }
}
