﻿namespace System.Windows.Interop
{
    using Uno.UI.Generic;

    public class ThreadMessageEventHandler : Proxy<global::Windows.UI.Xaml.Interop.ThreadMessageEventHandler>
    {
        public System.Object Target
        {
            get => __ProxyValue.Target;
        }

        public System.Reflection.MethodInfo Method
        {
            get => __ProxyValue.Method;
        }

        public ThreadMessageEventHandler(System.Object @object, System.IntPtr @method): base(@object, @method)
        {
        }

        public void Invoke(System.Windows.Interop.MSG msg, System.Boolean handled) => __ProxyValue.Invoke(@msg, @handled);
        public System.IAsyncResult BeginInvoke(System.Windows.Interop.MSG msg, System.Boolean handled, System.AsyncCallback callback, System.Object object) => __ProxyValue.BeginInvoke(@msg, @handled, @callback, @object);
        public void EndInvoke(System.Windows.Interop.MSG msg, System.Boolean handled, System.IAsyncResult result) => __ProxyValue.EndInvoke(@msg, @handled, @result);
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => __ProxyValue.GetObjectData(@info, @context);
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public System.Delegate[] GetInvocationList() => __ProxyValue.GetInvocationList();
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
        public System.Object Clone() => __ProxyValue.Clone();
        public System.Object DynamicInvoke(System.Object[] args) => __ProxyValue.DynamicInvoke(@args);
        public override System.String ToString() => __ProxyValue.ToString();
    }
}