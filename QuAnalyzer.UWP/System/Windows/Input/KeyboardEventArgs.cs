﻿namespace System.Windows.Input
{
    using Uno.UI.Generic;

    public class KeyboardEventArgs : Proxy<global::Windows.UI.Xaml.Input.KeyboardEventArgs>
    {
        public System.Windows.Input.KeyboardDevice KeyboardDevice
        {
            get => __ProxyValue.KeyboardDevice;
        }

        public System.Windows.Input.InputDevice Device
        {
            get => __ProxyValue.Device;
        }

        public System.Int32 Timestamp
        {
            get => __ProxyValue.Timestamp;
        }

        public System.Windows.RoutedEvent RoutedEvent
        {
            get => __ProxyValue.RoutedEvent;
            set => __ProxyValue.RoutedEvent = value;
        }

        public System.Boolean Handled
        {
            get => __ProxyValue.Handled;
            set => __ProxyValue.Handled = value;
        }

        public System.Object Source
        {
            get => __ProxyValue.Source;
            set => __ProxyValue.Source = value;
        }

        public System.Object OriginalSource
        {
            get => __ProxyValue.OriginalSource;
        }

        public KeyboardEventArgs(System.Windows.Input.KeyboardDevice @keyboard, System.Int32 @timestamp): base(@keyboard, @timestamp)
        {
        }

        public override System.String ToString() => __ProxyValue.ToString();
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
    }
}