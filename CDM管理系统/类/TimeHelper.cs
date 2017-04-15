using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    class TimeHelper
    {
        public static string GetTime()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            return year.ToString() + month.ToString().PadLeft(2, '0') 
                + day.ToString().PadLeft(2, '0') 
                + hour.ToString().PadLeft(2, '0') +
                minute.ToString().PadLeft(2, '0') + 
                second.ToString().PadLeft(2, '0');
        }

        public static string GetYYMMDDTime()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            return year.ToString() + month.ToString().PadLeft(2, '0') + day.ToString().PadLeft(2, '0');
        }

        public static string GetHHMMSSTime()
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            return hour.ToString().PadLeft(2, '0') + minute.ToString().PadLeft(2, '0') 
                + second.ToString().PadLeft(2, '0');
        }

    }
}
