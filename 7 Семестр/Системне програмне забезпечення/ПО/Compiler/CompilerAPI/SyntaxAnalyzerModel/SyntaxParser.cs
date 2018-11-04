using CompilerAPI.LexemAnalyzerModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CompilerAPI.SyntaxAnalyzerModel
{
    public class SyntaxParser
    {
        #region Переменные
        private List<Lexem> lexemList;
        #endregion

        #region Свойства

        #endregion

        #region Конструктор

        public SyntaxParser(IEnumerable<Lexem> _lexemList)
        {
            if (_lexemList == null)
            { throw new ArgumentNullException(nameof(_lexemList)); }

            lexemList = _lexemList.ToList();
        }



        #endregion

        #region Методы

        public ReadOnlyCollection<SyntaxNode> Parse()
        {
            if (lexemList == null)
            { throw new ArgumentNullException(nameof(lexemList)); }

            List<SyntaxNode> list = new List<SyntaxNode>();
            SyntaxNode root = new SyntaxNode("Program");

            // Перебрать все лексемы
            // взять лексему найти шаблон
            // если есть добавить в МП-автомат
            // если нету ошибка
            // проверить коне
            foreach (Lexem lexem in lexemList)
            {

            }

            for (int idx = 0; idx < 15; idx++)
            {
                SyntaxNode node = new SyntaxNode("Parent node #" + idx.ToString());

                for (int i = 0; i < 5; i++)
                {
                    node.AddChild(new SyntaxNode("Child node #" + i.ToString()));
                }

                root.AddChild(node);
            }
            list.Add(root);
            return list.AsReadOnly();
        }
        #endregion

    }
}
