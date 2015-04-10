using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Windows;
 
using Windows.UI.Xaml.Input;

namespace App3
{
    public class FriendlyListView : GridView
    {
        private ScrollViewer _viewport;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _viewport = (ScrollViewer)GetTemplateChild("ScrollViewer");
            _viewport.ViewChanged += OnViewportChanged;
        }

       

        public double ScrollPosition
        {
            get { return (double)GetValue(ViewPortProperty); }
            set { SetValue(ViewPortProperty, value); }
        }

        public static readonly DependencyProperty ViewPortProperty = DependencyProperty.Register(
            "ScrollPosition",
            typeof(double),
            typeof(FriendlyListView),
            new PropertyMetadata(0d, OnViewPortChanged));


        private void OnViewportChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            //ScrollPosition = _viewport.Viewport.Top;
            ScrollPosition = _viewport.VerticalOffset;
        }

        private static void OnViewPortChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var list = (FriendlyListView)d;

            if (list._viewport.ViewportHeight.Equals(list.ScrollPosition)) return;
            
        }
    }
}
