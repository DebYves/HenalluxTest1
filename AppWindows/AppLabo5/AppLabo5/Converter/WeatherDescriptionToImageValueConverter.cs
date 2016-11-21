using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace AppLabo5.Converter
{
    public class WeatherDescriptionToImageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var forecast = (string) value;
            if(forecast.Contains("nuageux"))
                return new BitmapImage(new Uri("ms-appx:/Images/nuage.jpg"));
            else
                return new BitmapImage(new Uri("ms-appx:/Images/soleil.jpg"));

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}