using CompilerAPI.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CompilerAPI.SyntaxAnalyzerModel
{
    /// <summary>
    /// Узел синтаксического дерева
    /// </summary>
    public class SyntaxNode : BindingProperty
    {
        private List<SyntaxNode> _items;
        public ReadOnlyCollection<SyntaxNode> Children { get { return _items.AsReadOnly(); } }
        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set
            {
                _displayName = value;
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public SyntaxNode(string displayName)
        {
            _items = new List<SyntaxNode>();
            DisplayName = displayName;
        }

        public void AddChild(SyntaxNode childNode)
        {
            if (childNode == null)
            { throw new ArgumentNullException(nameof(childNode)); }

            _items.Add(childNode);
        }
    }
}
