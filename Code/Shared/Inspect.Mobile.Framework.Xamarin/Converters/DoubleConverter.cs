using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Converters
{
    public class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
            {
                return value.ToString();
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var t = CultureInfo.CurrentCulture;
            double dbl;
            if (double.TryParse((value as string),out dbl))
            {
                return dbl;
            }
            return value;            
        }
    }
}
