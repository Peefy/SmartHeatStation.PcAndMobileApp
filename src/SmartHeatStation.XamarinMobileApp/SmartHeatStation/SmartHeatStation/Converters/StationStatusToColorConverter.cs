using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHeatStation.Converters
{
    class StationStatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var status = (Models.StationStatusEnum)value;
                switch(status)
                {
                    case Models.StationStatusEnum.Error:
                        return Color.Red;
                    case Models.StationStatusEnum.Running:
                        return Color.Lime;
                    case Models.StationStatusEnum.Warning:
                        return Color.Yellow;
                    case Models.StationStatusEnum.Unkown:
                        return Color.Gray;
                    default:
                        return Color.Gray;
                }
            }

            return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
