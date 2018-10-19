using CompilerAPI.Enum;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompilerAPI.LexemAnalyzerModel
{
    /// <summary>
    /// Определение синтаксической группы 
    /// </summary>
    public class LexemGroup
    {
        public string Value { get; private set; }
        private Regex _regex;
        private readonly LexemGroupType _tokenType;

        public LexemGroup(LexemGroupType tokenGroupType, string[] groupItems)
        {
            _tokenType = tokenGroupType;
            if (groupItems != null)
            {
                Value += @"";
                foreach (string item in groupItems)
                {
                    if(!string.IsNullOrEmpty(item))
                    {
                        if (item != groupItems.Last())
                            Value += item + "|";
                        else
                            Value += item;
                    }
                }
                _regex = new Regex(Value, RegexOptions.IgnoreCase);
            } else
            {
                _regex = new Regex("?");
            }
        }

        public Lexem Match(string inputString)
        {
            Match match = _regex.Match(inputString);
            if (match.Success)
            {   return new Lexem(_tokenType, match.Value); }

            return null; 
        }
    }
}
