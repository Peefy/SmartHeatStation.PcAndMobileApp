using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Converters
{
    class UserIdToAuthorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var strUserId = (string)value;
                if (strUserId == "自动化研究所" || strUserId == "DuGuDiaoLing")
                    return "管理员";
                return "用户";
            }

            return "用户";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
