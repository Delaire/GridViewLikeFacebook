using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace App3
{
    public class ScrollToMarginConverter : IValueConverter
    {
        public double OldScrollPosition { get; set; }
        

        //this will allow you to ease in the top bar and ease it out
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //var scrollPosition = (double)value;
            //var maxHeight = System.Convert.ToInt32(parameter)+60;

            //// to hide the navigation ar when the user first starts scrolling
            //var topMargin = -scrollPosition / 2;

            ////saving Value
            ////if OldPosition is inferiour to scrollPosition then user is scroll backwards (up)
            ////Scrolling up
            //if (OldScrollPosition > scrollPosition)
            //{
                //var newTopMargin = ((OldScrollPosition - scrollPosition) / 2) - maxHeight;

                //topMargin = Math.Min(0, newTopMargin);

                new MainPage().hideTopNav();
            //}
            //else
            //{
            //    //Scrolling down

            //    //saving old position to check to see when whe scroll up
            //    OldScrollPosition = scrollPosition;
            //    topMargin = Math.Max(-maxHeight, topMargin);
            //}

           
            //Debug.WriteLine("H: {0}", topMargin);
            //Debug.WriteLine("S: {0}", scrollPosition);

            return 140;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    //public class ScrollToOpacityConverter : IValueConverter
    //{
    //    public double OldPosition { get; set; }
    //    public object Convert(object value, Type targetType, object parameter, string language)
    //    {

    //        var scrollPosition = ((double)value);
    //        var scrollNow = scrollPosition / 2;
    //        var maxHeight = System.Convert.ToInt32(parameter); ;
    //        var opacity = Math.Min(maxHeight, scrollNow) / maxHeight;
          
    //        if (OldPosition > scrollPosition)
    //        {
    //            var newOpacity = ((scrollPosition - OldPosition)) / maxHeight;

    //            opacity = Math.Min(1, newOpacity);
    //        }
    //        else
    //        {
    //            //Scrolling down

    //            //saving old position to check to see when whe scroll up
    //            OldPosition = scrollPosition;
    //            //topMargin = Math.Max(-maxHeight, topMargin);
    //        }

    //        if (opacity < 0.01) opacity = 0;

    //        Debug.WriteLine("S: {0}", scrollNow);
    //        Debug.WriteLine("O: {0}", opacity);

    //        return (1 - opacity);
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, string language)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

}
