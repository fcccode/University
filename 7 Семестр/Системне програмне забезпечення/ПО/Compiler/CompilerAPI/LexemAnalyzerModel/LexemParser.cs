using CompilerAPI.Enum;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompilerAPI.LexemAnalyzerModel
{
    public class LexemParser
    {
        #region Переменные

        public const int MAX_IDENTIER_LENGTH = 32;
        private List<LexemGroup> lexemGroup; 
        
        #endregion

        #region Конструктор

        public LexemParser()
        {
            lexemGroup = new List<LexemGroup>();
            Initialize();
        }

        #endregion
     
        #region Методы

        public ReadOnlyCollection<Lexem> GetLexems(string sourceText)
        {
            List<Lexem> tokens = null;

            if (lexemGroup == null || lexemGroup.Count <= 0)
            { throw new ArgumentException("Отсутствует грамматика исходного языка"); }

            string formingPattern = string.Empty;
            foreach (LexemGroup item in lexemGroup)
            {
                if (item != lexemGroup.Last())
                    formingPattern += item.Value + "|";
                else
                    formingPattern += item.Value;
            }

            if (string.IsNullOrEmpty(formingPattern))
            { throw new ArgumentException("Не удалось сформировать регулярное выражение"); }

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
            else
            {
                throw new System.Exception("Не корректные входные данные");
            }

            tokens.Add(new Lexem(LexemGroupType.END_OF_SEQUENCE, string.Empty));
            return tokens.AsReadOnly();
        }
        private Lexem FindContext(string lqlText)
        {
            Lexem lexem = null;
            foreach (var tokenDefinition in lexemGroup)
            {
                lexem = tokenDefinition.Match(lqlText);

                if (lexem != null)
                { return lexem; }
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
                "while", "break", "continue", "return"
            };

            string[] identifiers = new string[]
            {
                @"__\w{1,32}\s?" , @"_\w{1,32}\s?", @"\b\w+\s?"
            };
            lexemGroup.Add(new LexemGroup(LexemGroupType.KEYWORD, keywords));
            lexemGroup.Add(new LexemGroup(LexemGroupType.IDENTIFIER, identifiers));
            lexemGroup.Add(new LexemGroup(LexemGroupType.SEPARATOR, separators));
        } 
     
        #endregion
    }
}
