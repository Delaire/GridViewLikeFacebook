using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using App3;
using App3.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            DataContext = App.ViewModel;
        }

    

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }


        public void hideTopNav()
        {
            try
            {
                //Storyboard sb = this.FindResource("HideTopNavStoryboard") as Storyboard;
                //Storyboard.SetTarget(sb, this.btn);
                //sb.Begin();
                NavStackPanel.RenderTransform = new CompositeTransform() { TranslateY = -140 };
                //HideTopNavStoryboard.Begin();
            }
            catch (Exception ex)
            {
                
               Debug.WriteLine(ex.Message);
            }
          
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            hideTopNav();
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            NavStackPanel.RenderTransform = new CompositeTransform();
            ShowTopNavStoryboard.Begin();
        }
    }
}
