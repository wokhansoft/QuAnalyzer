﻿namespace System.Windows.Input
{
    using Uno.UI.Generic;

    public class MouseEventArgs : Proxy<global::Windows.UI.Xaml.Input.MouseEventArgs>
    {
        public System.Windows.Input.MouseDevice MouseDevice
        {
            get => __ProxyValue.MouseDevice;
        }

        public System.Windows.Input.StylusDevice StylusDevice
        {
            get => __ProxyValue.StylusDevice;
        }

        public System.Windows.Input.MouseButtonState LeftButton
        {
            get => __ProxyValue.LeftButton;
        }

        public System.Windows.Input.MouseButtonState RightButton
        {
            get => __ProxyValue.RightButton;
        }

        public System.Windows.Input.MouseButtonState MiddleButton
        {
            get => __ProxyValue.MiddleButton;
        }

        public System.Windows.Input.MouseButtonState XButton1
        {
            get => __ProxyValue.XButton1;
        }

        public System.Windows.Input.MouseButtonState XButton2
        {
            get => __ProxyValue.XButton2;
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

        public MouseEventArgs(System.Windows.Input.MouseDevice @mouse, System.Int32 @timestamp): base(@mouse, @timestamp)
        {
        }

        public MouseEventArgs(System.Windows.Input.MouseDevice @mouse, System.Int32 @timestamp, System.Windows.Input.StylusDevice @stylusDevice): base(@mouse, @timestamp, @stylusDevice)
        {
        }

        public System.Windows.Point GetPosition(System.Windows.IInputElement relativeTo) => __ProxyValue.GetPosition(@relativeTo);
        public override System.String ToString() => __ProxyValue.ToString();
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
    }
}