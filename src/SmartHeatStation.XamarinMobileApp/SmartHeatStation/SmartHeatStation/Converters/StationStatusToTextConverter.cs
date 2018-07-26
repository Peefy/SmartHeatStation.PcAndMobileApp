using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Converters
{
    class StationStatusToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var status = (Models.StationStatusEnum)value;
                switch (status)
                {
                    case Models.StationStatusEnum.Error:
                        return "故障";
                    case Models.StationStatusEnum.Running:
                        return "正常";
                    case Models.StationStatusEnum.Warning:
                        return "报警";
                    case Models.StationStatusEnum.Unkown:
                        return "----";
                    default:
                        return "未知";
                }
            }

            return "故障";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
