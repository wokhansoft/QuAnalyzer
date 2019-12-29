﻿namespace System.Windows.Media
{
    using Uno.UI.Generic;

    public class Pen : Proxy<global::Windows.UI.Xaml.Media.Pen>
    {
        public System.Windows.Media.Brush Brush
        {
            get => __ProxyValue.Brush;
            set => __ProxyValue.Brush = value;
        }

        public System.Double Thickness
        {
            get => __ProxyValue.Thickness;
            set => __ProxyValue.Thickness = value;
        }

        public System.Windows.Media.PenLineCap StartLineCap
        {
            get => __ProxyValue.StartLineCap;
            set => __ProxyValue.StartLineCap = value;
        }

        public System.Windows.Media.PenLineCap EndLineCap
        {
            get => __ProxyValue.EndLineCap;
            set => __ProxyValue.EndLineCap = value;
        }

        public System.Windows.Media.PenLineCap DashCap
        {
            get => __ProxyValue.DashCap;
            set => __ProxyValue.DashCap = value;
        }

        public System.Windows.Media.PenLineJoin LineJoin
        {
            get => __ProxyValue.LineJoin;
            set => __ProxyValue.LineJoin = value;
        }

        public System.Double MiterLimit
        {
            get => __ProxyValue.MiterLimit;
            set => __ProxyValue.MiterLimit = value;
        }

        public System.Windows.Media.DashStyle DashStyle
        {
            get => __ProxyValue.DashStyle;
            set => __ProxyValue.DashStyle = value;
        }

        public System.Boolean HasAnimatedProperties
        {
            get => __ProxyValue.HasAnimatedProperties;
        }

        public System.Boolean CanFreeze
        {
            get => __ProxyValue.CanFreeze;
        }

        public System.Boolean IsFrozen
        {
            get => __ProxyValue.IsFrozen;
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

        public Pen(): base()
        {
        }

        public Pen(System.Windows.Media.Brush @brush, System.Double @thickness): base(@brush, @thickness)
        {
        }

        public System.Windows.Media.Pen Clone() => __ProxyValue.Clone();
        public System.Windows.Media.Pen CloneCurrentValue() => __ProxyValue.CloneCurrentValue();
        public void ApplyAnimationClock(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock) => __ProxyValue.ApplyAnimationClock(@dp, @clock);
        public void ApplyAnimationClock(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock, System.Windows.Media.Animation.HandoffBehavior handoffBehavior) => __ProxyValue.ApplyAnimationClock(@dp, @clock, @handoffBehavior);
        public void BeginAnimation(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation) => __ProxyValue.BeginAnimation(@dp, @animation);
        public void BeginAnimation(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation, System.Windows.Media.Animation.HandoffBehavior handoffBehavior) => __ProxyValue.BeginAnimation(@dp, @animation, @handoffBehavior);
        public System.Object GetAnimationBaseValue(System.Windows.DependencyProperty dp) => __ProxyValue.GetAnimationBaseValue(@dp);
        public System.Windows.Freezable GetAsFrozen() => __ProxyValue.GetAsFrozen();
        public System.Windows.Freezable GetCurrentValueAsFrozen() => __ProxyValue.GetCurrentValueAsFrozen();
        public void Freeze() => __ProxyValue.Freeze();
        public void add_Changed(System.EventHandler value) => __ProxyValue.add_Changed(@value);
        public void remove_Changed(System.EventHandler value) => __ProxyValue.remove_Changed(@value);
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