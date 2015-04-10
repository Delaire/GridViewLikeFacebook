

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace App2
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




        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            NavStackPanel.RenderTransform = new CompositeTransform();
            HideTopNavStoryboard.Begin();
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            NavStackPanel.RenderTransform = new CompositeTransform();
            ShowTopNavStoryboard.Begin();
        }
    }



}