﻿namespace System.Windows.Documents
{
    using Uno.UI.Generic;

    public class TableRowGroupCollection : Proxy<global::Windows.UI.Xaml.Documents.TableRowGroupCollection>
    {
        public System.Int32 Count
        {
            get => __ProxyValue.Count;
        }

        public System.Boolean IsReadOnly
        {
            get => __ProxyValue.IsReadOnly;
        }

        public System.Boolean IsSynchronized
        {
            get => __ProxyValue.IsSynchronized;
        }

        public System.Object SyncRoot
        {
            get => __ProxyValue.SyncRoot;
        }

        public System.Int32 Capacity
        {
            get => __ProxyValue.Capacity;
            set => __ProxyValue.Capacity = value;
        }

        public System.Windows.Documents.TableRowGroup Item
        {
            get => __ProxyValue.Item;
            set => __ProxyValue.Item = value;
        }

        public void CopyTo(System.Array array, System.Int32 index) => __ProxyValue.CopyTo(@array, @index);
        public void CopyTo(System.Windows.Documents.TableRowGroup[] array, System.Int32 index) => __ProxyValue.CopyTo(@array, @index);
        public void Add(System.Windows.Documents.TableRowGroup item) => __ProxyValue.Add(@item);
        public void Clear() => __ProxyValue.Clear();
        public System.Boolean Contains(System.Windows.Documents.TableRowGroup item) => __ProxyValue.Contains(@item);
        public System.Int32 IndexOf(System.Windows.Documents.TableRowGroup item) => __ProxyValue.IndexOf(@item);
        public void Insert(System.Int32 index, System.Windows.Documents.TableRowGroup item) => __ProxyValue.Insert(@index, @item);
        public System.Boolean Remove(System.Windows.Documents.TableRowGroup item) => __ProxyValue.Remove(@item);
        public void RemoveAt(System.Int32 index) => __ProxyValue.RemoveAt(@index);
        public void RemoveRange(System.Int32 index, System.Int32 count) => __ProxyValue.RemoveRange(@index, @count);
        public void TrimToSize() => __ProxyValue.TrimToSize();
        public override System.String ToString() => __ProxyValue.ToString();
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
    }
}