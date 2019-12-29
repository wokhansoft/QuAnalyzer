﻿namespace System.Windows.Controls
{
    using Uno.UI.Generic;

    public class DataGridBoundColumn : Proxy<global::Windows.UI.Xaml.Controls.DataGridBoundColumn>
    {
        public System.Windows.Data.BindingBase Binding
        {
            get => __ProxyValue.Binding;
            set => __ProxyValue.Binding = value;
        }

        public System.Windows.Style ElementStyle
        {
            get => __ProxyValue.ElementStyle;
            set => __ProxyValue.ElementStyle = value;
        }

        public System.Windows.Style EditingElementStyle
        {
            get => __ProxyValue.EditingElementStyle;
            set => __ProxyValue.EditingElementStyle = value;
        }

        public System.Windows.Data.BindingBase ClipboardContentBinding
        {
            get => __ProxyValue.ClipboardContentBinding;
            set => __ProxyValue.ClipboardContentBinding = value;
        }

        public System.Object Header
        {
            get => __ProxyValue.Header;
            set => __ProxyValue.Header = value;
        }

        public System.Windows.Style HeaderStyle
        {
            get => __ProxyValue.HeaderStyle;
            set => __ProxyValue.HeaderStyle = value;
        }

        public System.String HeaderStringFormat
        {
            get => __ProxyValue.HeaderStringFormat;
            set => __ProxyValue.HeaderStringFormat = value;
        }

        public System.Windows.DataTemplate HeaderTemplate
        {
            get => __ProxyValue.HeaderTemplate;
            set => __ProxyValue.HeaderTemplate = value;
        }

        public System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
        {
            get => __ProxyValue.HeaderTemplateSelector;
            set => __ProxyValue.HeaderTemplateSelector = value;
        }

        public System.Windows.Style CellStyle
        {
            get => __ProxyValue.CellStyle;
            set => __ProxyValue.CellStyle = value;
        }

        public System.Boolean IsReadOnly
        {
            get => __ProxyValue.IsReadOnly;
            set => __ProxyValue.IsReadOnly = value;
        }

        public System.Windows.Controls.DataGridLength Width
        {
            get => __ProxyValue.Width;
            set => __ProxyValue.Width = value;
        }

        public System.Double MinWidth
        {
            get => __ProxyValue.MinWidth;
            set => __ProxyValue.MinWidth = value;
        }

        public System.Double MaxWidth
        {
            get => __ProxyValue.MaxWidth;
            set => __ProxyValue.MaxWidth = value;
        }

        public System.Double ActualWidth
        {
            get => __ProxyValue.ActualWidth;
        }

        public System.Int32 DisplayIndex
        {
            get => __ProxyValue.DisplayIndex;
            set => __ProxyValue.DisplayIndex = value;
        }

        public System.String SortMemberPath
        {
            get => __ProxyValue.SortMemberPath;
            set => __ProxyValue.SortMemberPath = value;
        }

        public System.Boolean CanUserSort
        {
            get => __ProxyValue.CanUserSort;
            set => __ProxyValue.CanUserSort = value;
        }

        public System.Nullable<System.ComponentModel.ListSortDirection> SortDirection
        {
            get => __ProxyValue.SortDirection;
            set => __ProxyValue.SortDirection = value;
        }

        public System.Boolean IsAutoGenerated
        {
            get => __ProxyValue.IsAutoGenerated;
        }

        public System.Boolean IsFrozen
        {
            get => __ProxyValue.IsFrozen;
        }

        public System.Boolean CanUserReorder
        {
            get => __ProxyValue.CanUserReorder;
            set => __ProxyValue.CanUserReorder = value;
        }

        public System.Windows.Style DragIndicatorStyle
        {
            get => __ProxyValue.DragIndicatorStyle;
            set => __ProxyValue.DragIndicatorStyle = value;
        }

        public System.Boolean CanUserResize
        {
            get => __ProxyValue.CanUserResize;
            set => __ProxyValue.CanUserResize = value;
        }

        public System.Windows.Visibility Visibility
        {
            get => __ProxyValue.Visibility;
            set => __ProxyValue.Visibility = value;
        }

        public System.Windows.DependencyObjectType DependencyObjectType
        {
            get => __ProxyValue.DependencyObjectType;
        }

        public System.Boolean IsSealed
        {
            get => __ProxyValue.IsSealed;
        }

        public System.Windows.Threading.Dispatcher Dispatcher
        {
            get => __ProxyValue.Dispatcher;
        }

        public System.Object OnCopyingCellClipboardContent(System.Object item) => __ProxyValue.OnCopyingCellClipboardContent(@item);
        public void OnPastingCellClipboardContent(System.Object item, System.Object cellContent) => __ProxyValue.OnPastingCellClipboardContent(@item, @cellContent);
        public void add_CopyingCellClipboardContent(System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs> value) => __ProxyValue.add_CopyingCellClipboardContent(@value);
        public void remove_CopyingCellClipboardContent(System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs> value) => __ProxyValue.remove_CopyingCellClipboardContent(@value);
        public void add_PastingCellClipboardContent(System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs> value) => __ProxyValue.add_PastingCellClipboardContent(@value);
        public void remove_PastingCellClipboardContent(System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs> value) => __ProxyValue.remove_PastingCellClipboardContent(@value);
        public System.Windows.FrameworkElement GetCellContent(System.Object dataItem) => __ProxyValue.GetCellContent(@dataItem);
        public System.Windows.FrameworkElement GetCellContent(System.Windows.Controls.DataGridRow dataGridRow) => __ProxyValue.GetCellContent(@dataGridRow);
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
        public System.Object GetValue(System.Windows.DependencyProperty dp) => __ProxyValue.GetValue(@dp);
        public void SetValue(System.Windows.DependencyProperty dp, System.Object value) => __ProxyValue.SetValue(@dp, @value);
        public void SetCurrentValue(System.Windows.DependencyProperty dp, System.Object value) => __ProxyValue.SetCurrentValue(@dp, @value);
        public void SetValue(System.Windows.DependencyPropertyKey key, System.Object value) => __ProxyValue.SetValue(@key, @value);
        public void ClearValue(System.Windows.DependencyProperty dp) => __ProxyValue.ClearValue(@dp);
        public void ClearValue(System.Windows.DependencyPropertyKey key) => __ProxyValue.ClearValue(@key);
        public void CoerceValue(System.Windows.DependencyProperty dp) => __ProxyValue.CoerceValue(@dp);
        public void InvalidateProperty(System.Windows.DependencyProperty dp) => __ProxyValue.InvalidateProperty(@dp);
        public System.Object ReadLocalValue(System.Windows.DependencyProperty dp) => __ProxyValue.ReadLocalValue(@dp);
        public System.Windows.LocalValueEnumerator GetLocalValueEnumerator() => __ProxyValue.GetLocalValueEnumerator();
        public System.Boolean CheckAccess() => __ProxyValue.CheckAccess();
        public void VerifyAccess() => __ProxyValue.VerifyAccess();
        public override System.String ToString() => __ProxyValue.ToString();
    }
}