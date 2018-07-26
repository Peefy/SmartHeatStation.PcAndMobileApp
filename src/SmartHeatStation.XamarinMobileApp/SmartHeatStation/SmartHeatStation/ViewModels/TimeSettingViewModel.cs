using System;

namespace SmartHeatStation.ViewModels
{
    public class TimeSettingViewModel : ViewModelBase
    {
        public TimeSettingViewModel()
        {
            Title = "时间设置";
        }

        bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set { SetProperty(ref isChecked, value); }
        }

        TimeSpan timeSpan = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,0);
        public TimeSpan TimeSpan
        {
            get { return timeSpan; }
            set { SetProperty(ref timeSpan, value); }
        }

        DateTime dateTime = DateTime.Now;
        public DateTime DateTime
        {
            get { return dateTime; }
            set { SetProperty(ref dateTime, value); }
        }

    }
}
