﻿namespace System.Windows.Media.Imaging
{
    using Uno.UI.Generic;

    public class JpegBitmapEncoder : Proxy<global::Windows.UI.Xaml.Media.Imaging.JpegBitmapEncoder>
    {
        public System.Int32 QualityLevel
        {
            get => __ProxyValue.QualityLevel;
            set => __ProxyValue.QualityLevel = value;
        }

        public System.Windows.Media.Imaging.Rotation Rotation
        {
            get => __ProxyValue.Rotation;
            set => __ProxyValue.Rotation = value;
        }

        public System.Boolean FlipHorizontal
        {
            get => __ProxyValue.FlipHorizontal;
            set => __ProxyValue.FlipHorizontal = value;
        }

        public System.Boolean FlipVertical
        {
            get => __ProxyValue.FlipVertical;
            set => __ProxyValue.FlipVertical = value;
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Media.ColorContext> ColorContexts
        {
            get => __ProxyValue.ColorContexts;
            set => __ProxyValue.ColorContexts = value;
        }

        public System.Windows.Media.Imaging.BitmapSource Thumbnail
        {
            get => __ProxyValue.Thumbnail;
            set => __ProxyValue.Thumbnail = value;
        }

        public System.Windows.Media.Imaging.BitmapMetadata Metadata
        {
            get => __ProxyValue.Metadata;
            set => __ProxyValue.Metadata = value;
        }

        public System.Windows.Media.Imaging.BitmapSource Preview
        {
            get => __ProxyValue.Preview;
            set => __ProxyValue.Preview = value;
        }

        public System.Windows.Media.Imaging.BitmapCodecInfo CodecInfo
        {
            get => __ProxyValue.CodecInfo;
        }

        public System.Windows.Media.Imaging.BitmapPalette Palette
        {
            get => __ProxyValue.Palette;
            set => __ProxyValue.Palette = value;
        }

        public System.Collections.Generic.IList<System.Windows.Media.Imaging.BitmapFrame> Frames
        {
            get => __ProxyValue.Frames;
            set => __ProxyValue.Frames = value;
        }

        public System.Windows.Threading.Dispatcher Dispatcher
        {
            get => __ProxyValue.Dispatcher;
        }

        public JpegBitmapEncoder(): base()
        {
        }

        public void Save(System.IO.Stream stream) => __ProxyValue.Save(@stream);
        public System.Boolean CheckAccess() => __ProxyValue.CheckAccess();
        public void VerifyAccess() => __ProxyValue.VerifyAccess();
        public override System.String ToString() => __ProxyValue.ToString();
        public override System.Boolean Equals(System.Object obj) => __ProxyValue.Equals(@obj);
        public override System.Int32 GetHashCode() => __ProxyValue.GetHashCode();
    }
}