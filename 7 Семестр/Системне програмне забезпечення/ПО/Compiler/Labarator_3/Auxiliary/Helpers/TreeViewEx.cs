using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Labarator_3.Auxiliary
{
    public class TreeViewEx : TreeView
    {
        static TreeViewEx()
        {
            SelectedObjectProperty = DependencyProperty.Register(
                "SelectedObject", typeof(object), typeof(TreeViewEx), new FrameworkPropertyMetadata(OnSelectedObjectChanged));
        }

        public static readonly DependencyProperty SelectedObjectProperty;


        /// <summary>
        /// Выделенный элемент дерева
        /// </summary>
        public object SelectedObject
        {
            get
            { return GetValue(SelectedObjectProperty); }
            set
            { SetValue(SelectedObjectProperty, value); }
        }

        /// <summary>
        /// Получить ветку дерева на основе ее внутреннего активного элемента
        /// (визуального компонента, используемого в шаблоне представления ветки)
        /// </summary>
        /// <param name="innerObject"> Внутренный активный элемент </param>
        /// <returns> Ветка дерева </returns>
        private TreeViewItem ExtractItemContainerThroughInnerObject(DependencyObject innerObject)
        {
            while ((innerObject != null) && !(innerObject is TreeViewItem))
                innerObject = VisualTreeHelper.GetParent(innerObject);

            return innerObject as TreeViewItem;
        }

        /// <summary>
        /// Выделить ветку дерева, соответствующую указанному элементу, с раскрытием всех родительских веток
        /// </summary>
        /// <param name="treeView"> Дерево элементов </param>
        /// <param name="parentItemContainer"> Родительская ветка по отношению к выделяемой ветке </param>
        /// <param name="element"> Элемент </param>
        /// <returns></returns>
        private static bool ExpandAndSelectItem(TreeViewEx treeView, ItemsControl parentItemContainer, object element)
        {
            foreach (object item in parentItemContainer.Items)
            {
                if (item.Equals(element))
                {
                    TreeViewItem itemContainer = parentItemContainer.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                    if (itemContainer != null)
                    {
                        itemContainer.IsSelected = true;
                        itemContainer.BringIntoView();
                        itemContainer.Focus();
                    }
                    else
                    {
                        if (parentItemContainer.ItemContainerGenerator.Status != GeneratorStatus.ContainersGenerated)
                        {
                            EventHandler handler = null;
                            handler = (s, e) =>
                            {
                                if (((ItemContainerGenerator)s).Status == GeneratorStatus.ContainersGenerated)
                                {
                                    ExpandAndSelectItem(treeView, parentItemContainer, element);
                                    ((ItemContainerGenerator)s).StatusChanged -= handler;
                                }
                            };
                            parentItemContainer.ItemContainerGenerator.StatusChanged += handler;
                        }
                    }

                    return true;
                }
            }

            foreach (object item in parentItemContainer.Items)
            {
                TreeViewItem itemContainer = parentItemContainer.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                if (itemContainer != null)
                {
                    bool expState = itemContainer.IsExpanded;
                    itemContainer.IsExpanded = true;
                    if (itemContainer.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated)
                    {
                        if (ExpandAndSelectItem(treeView, itemContainer, element))
                            return true;
                        itemContainer.IsExpanded = expState;
                    }
                    else
                    {
                        EventHandler handler = null;
                        handler = (s, e) =>
                        {
                            if (itemContainer.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated)
                            {
                                if (!ExpandAndSelectItem(treeView, itemContainer, element))
                                    itemContainer.IsExpanded = expState;
                                itemContainer.ItemContainerGenerator.StatusChanged -= handler;
                            }
                        };
                        itemContainer.ItemContainerGenerator.StatusChanged += handler;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Обработка изменения выделенного элемента дерева
        /// </summary>
        private static void OnSelectedObjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            TreeViewEx treeView = (TreeViewEx)d;
            if (args.NewValue != null)
                ExpandAndSelectItem(treeView, treeView, args.NewValue);
            else
            {
                TreeViewItem item = treeView.FindSelectedItem(treeView);
                if (item != null)
                    item.IsSelected = false;
            }
        }

        /// <summary>
        /// Выделение ветки дерева при нажатии правой кнопки мыши
        /// </summary>
        protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs args)
        {
            base.OnPreviewMouseRightButtonDown(args);

            TreeViewItem item = ExtractItemContainerThroughInnerObject(args.OriginalSource as DependencyObject);
            if (item != null)
                item.IsSelected = true;
        }

        /// <summary>
        /// Установка выделенного элемента при изменении выделенной ветки дерева
        /// </summary>
        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> args)
        {
            base.OnSelectedItemChanged(args);
            SelectedObject = args.NewValue;
        }

        /// <summary>
        /// Найти выделенную ветку дерева
        /// </summary>
        /// <param name="parentItem"> Родительская ветка выделенной </param>
        /// <returns> Выделенная ветка дерева </returns>
        private TreeViewItem FindSelectedItem(ItemsControl parentItem)
        {
            if (parentItem.ItemContainerGenerator.Status != GeneratorStatus.ContainersGenerated)
                return null;

            for (int index = 0; index < parentItem.Items.Count; index++)
            {
                TreeViewItem item = parentItem.ItemContainerGenerator.ContainerFromIndex(index) as TreeViewItem;
                if (item != null)
                {
                    if (item.IsSelected)
                        return item;

                    if (item.Items.Count != 0)
                    {
                        TreeViewItem subItem = FindSelectedItem(item);
                        if (subItem != null)
                            return subItem;
                    }
                }
            }

            return null;
        }
    }
}