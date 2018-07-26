using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationServiceV2.Helpers
{
    public static class TimeHelper
    {
        public static string GetUpLoadTime()
        {

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string hourStr = time.Substring(11, 2);

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            return year.ToString() + month.ToString().PadLeft(2, '0')
                + day.ToString().PadLeft(2, '0')
                + hourStr +
                minute.ToString().PadLeft(2, '0') +
                (second / 30).ToString();
        }
    }
}
