﻿namespace System.Windows.Data
{
    using Uno.UI.Generic;

    public class UpdateSourceExceptionFilterCallback : Proxy<global::Windows.UI.Xaml.Data.UpdateSourceExceptionFilterCallback>
    {
        public System.Object Target
        {
            get => __ProxyValue.Target;
        }

        public System.Reflection.MethodInfo Method
        {
            get => __ProxyValue.Method;
        }

        public UpdateSourceExceptionFilterCallback(System.Object @object, System.IntPtr @method): base(@object, @method)
        {
        }

        public System.Object Invoke(System.Object bindExpression, System.Exception exception) => __ProxyValue.Invoke(@bindExpression, @exception);
        public System.IAsyncResult BeginInvoke(System.Object bindExpression, System.Exception exception, System.AsyncCallback callback, System.Object object) => __ProxyValue.BeginInvoke(@bindExpression, @exception, @callback, @object);
        public System.Object EndInvoke(System.IAsyncResult result) => __ProxyValue.EndInvoke(@result);
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => __ProxyValue.GetObjectData(@info, @context);
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public System.Delegate[] GetInvocationList() => __ProxyValue.GetInvocationList();
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
        public System.Object Clone() => __ProxyValue.Clone();
        public System.Object DynamicInvoke(System.Object[] args) => __ProxyValue.DynamicInvoke(@args);
        public override System.String ToString() => __ProxyValue.ToString();
    }
}