using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Converters
{
    public class BoolToWarningColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var result = (bool)value;
                if (result == true)
                    return Color.FromHex("#1976D2");
                return Color.FromHex("#F29F3F");
            }
            return Color.FromHex("#F29F3F");
        }

        public object BoolConvert(object value)
        {
            if (value != null)
            {
                var result = (bool)value;
                if (result == false)
                    return Color.FromHex("#1976D2");
                return Color.FromHex("#F29F3F");
            }
            return Color.FromHex("#F29F3F");
        }

        public object StringConvert(object value)
        {
            if (value != null)
            {
                var result = (string)value;
                if (result == "False")
                    return Color.FromHex("#1976D2");
                return Color.FromHex("#F29F3F");
            }
            return Color.FromHex("#F29F3F");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
