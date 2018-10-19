using CompilerAPI.Enum;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompilerAPI.LexemAnalyzerModel
{
    public class LexemParser
    {
        public const int MAX_IDENTIER_LENGTH = 32;
        private List<LexemGroup> tokenGroup;

        public LexemParser()
        {
            tokenGroup = new List<LexemGroup>();
            Initialize();
        }
        public ReadOnlyCollection<Lexem> GetLexems(string sourceText)
        {
            List<Lexem> tokens = null;

            if (tokenGroup == null || tokenGroup.Count <= 0)
            { return null; }

            string formingPattern = string.Empty;
            foreach (LexemGroup item in tokenGroup)
            {
                if(item != tokenGroup.Last())
                    formingPattern += item.Value + "|";
                else
                    formingPattern += item.Value;
            }

            if (string.IsNullOrEmpty(formingPattern))
            { return null; }

            MatchCollection collection = Regex.Matches(sourceText, formingPattern);
            if (collection.Count > 0)
            {
                tokens = new List<Lexem>();
                Lexem context = null;
                foreach (Match item in collection)
                {
                    if (string.IsNullOrEmpty(item.Value))
                        continue;

                    context = FindContext(item.Value);
                    if (context != null)
                        tokens.Add(context);
                }
            }

            tokens.Add(new Lexem(LexemGroupType.END_OF_SEQUENCE, string.Empty));
            return tokens.AsReadOnly();
        }
        public bool RunScanning(IEnumerable<Lexem> lexems)
        {
            List<Lexem> list = lexems.ToList();
            return true;
        }
        private Lexem FindContext(string lqlText)
        {
            Lexem lexem = null;
            foreach (var tokenDefinition in tokenGroup)
            {
                lexem = tokenDefinition.Match(lqlText);

                if (lexem != null)
                {   return lexem; }
            }

            return null;
        }
        private void Initialize()
        {
            string[] separators = new string[]
                       {
                @"\{", @"\}", @"\(", @"\)", @"\[", @"\]", @"\;" , @"\:", @"\`", @"\'", @"\." , @"\?", @"\+", @"\-", @"\*", @"\/", @"\^",
                @"\~", @"\=", @"\!", @"\>", @"\<"
                       };

            string[] keywords = new string[]
            {
                "int", "double", "float", "char", "string","struct", "main", "static", "if", "else", "switch",
                "while", "break", "continue"
            };

            string[] identifiers = new string[]
            {
                @"__\w{1,32}\s?" , @"_\w{1,32}\s?", @"\b\w+\s?"
            };
            tokenGroup.Add(new LexemGroup(LexemGroupType.KEYWORD, keywords));
            tokenGroup.Add(new LexemGroup(LexemGroupType.IDENTIFIER, identifiers));
            tokenGroup.Add(new LexemGroup(LexemGroupType.SEPARATOR, separators));
        }
    }
}
