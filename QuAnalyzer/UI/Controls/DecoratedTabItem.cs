﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuAnalyzer.UI.Controls
{
    /// <summary>
    /// Logique d'interaction pour DecoratedTabItem.xaml
    /// </summary>
    public class DecoratedTabItem : TabItem
    {
        [Bindable(true)]
        public object Image { get; set; }
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(nameof(Image), typeof(object), typeof(DecoratedTabItem), new PropertyMetadata(null));

        static DecoratedTabItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DecoratedTabItem), new FrameworkPropertyMetadata(typeof(DecoratedTabItem)));
        }
    }
}
