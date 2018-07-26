using System;

namespace SmartHeatStation.Helper
{
    public class TimerHelper
    {

        public static bool IsCheckNotNow;

        static ViewModels.TimeSettingViewModel timeViewModel
        {
            get { return Apphelper.HomePage?.HomeMenupage?.viewModel?.TimeViewModel; }
        }

        public static string GetUpLoadTime()
        {

            DateTime nowBefore30Sec = DateTime.Now - TimeSpan.FromSeconds(30);
            string time = nowBefore30Sec.ToString("yyyy-MM-dd HH:mm:ss");
            string hourStr = time.Substring(11, 2);
            int year = nowBefore30Sec.Year;
            int month = nowBefore30Sec.Month;
            int day = nowBefore30Sec.Day;
            int hour = nowBefore30Sec.Hour;
            int minute = nowBefore30Sec.Minute;
            int second = nowBefore30Sec.Second;

            if (IsCheckNotNow == false)
            {
                return year.ToString() + month.ToString().PadLeft(2, '0')
                    + day.ToString().PadLeft(2, '0')
                    + hourStr +
                    minute.ToString().PadLeft(2, '0') +
                (second / 30).ToString();
            }
            else
            {
                int pYear = timeViewModel.DateTime.Year;
                int pMonth = timeViewModel.DateTime.Month;
                int pDay = timeViewModel.DateTime.Day;
                int pHour = timeViewModel.TimeSpan.Hours;
                int pMin = timeViewModel.TimeSpan.Minutes;
                int pSecond = 0;
                return pYear.ToString() + pMonth.ToString().PadLeft(2, '0')
                   + pDay.ToString().PadLeft(2, '0')
                   + pHour.ToString().PadLeft(2, '0') +
                   pMin.ToString().PadLeft(2, '0') +
               (pSecond / 30).ToString();
            }

        }

        public static string GetUpLoadTime(DateTime inTime)
        {

            DateTime nowBefore30Sec = inTime;
            string time = nowBefore30Sec.ToString("yyyy-MM-dd HH:mm:ss");
            string hourStr = time.Substring(11, 2);
            int year = nowBefore30Sec.Year;
            int month = nowBefore30Sec.Month;
            int day = nowBefore30Sec.Day;
            int hour = nowBefore30Sec.Hour;
            int minute = nowBefore30Sec.Minute;
            int second = nowBefore30Sec.Second;

            if (IsCheckNotNow == false)
            {
                return year.ToString() + month.ToString().PadLeft(2, '0')
                    + day.ToString().PadLeft(2, '0')
                    + hourStr +
                    minute.ToString().PadLeft(2, '0') +
                (second / 10).ToString();
            }
            else
            {
                int pHour = timeViewModel.TimeSpan.Hours;
                int pMin = timeViewModel.TimeSpan.Minutes;
                int pSecond = 0;
                return year.ToString() + month.ToString().PadLeft(2, '0')
                   + day.ToString().PadLeft(2, '0')
                   + pHour.ToString().PadLeft(2, '0') +
                   pMin.ToString().PadLeft(2, '0') +
               (pSecond / 10).ToString();
            }

        }

        public static DateTime[] GetUpLoadTimes()
        {

            DateTime nowBefore60Sec = DateTime.Now + TimeSpan.FromSeconds(60);
            DateTime[] checkTimes = new DateTime[12];
            for(int i = 0;i<12 ;++i)
                checkTimes[i] = nowBefore60Sec - TimeSpan.FromSeconds(i * 10);
            return checkTimes;

        }

    }
}
