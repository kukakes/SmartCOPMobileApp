using SmartCOPMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SmartCOPMobileApp.Converters
{
    class DrinkBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = Color.Yellow;

            Drink drink = value as Drink;
            if (drink is Juice)
                color = Color.Orange;
            else if (drink is Beer)
                color = Color.LightSkyBlue;
            else if (drink is Soda)
                color = Color.BlanchedAlmond;

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
