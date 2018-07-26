using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeatStation.Models
{
    public class Item : BaseDataObject
    {
        string stationName = string.Empty;
        public string StationName
        {
            get { return stationName; }
            set { SetProperty(ref stationName, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        bool isLast = false;
        public bool IsLast
        {
            get { return isLast; }
            set { SetProperty(ref isLast, value); }
        }

        public bool IsNotLast
        {
            get { return !isLast; }
            set { SetProperty(ref isLast, !value); }
        }

        bool isLoadMore = true;
        public bool IsLoadMore
        {
            get { return isLoadMore; }
            set { SetProperty(ref isLoadMore, value); }
        }

        bool isAlarm = false;
        public bool IsAlarm
        {
            get { return isAlarm; }
            set { SetProperty(ref isAlarm, value); }
        }

        bool isError = false;
        public bool IsError
        {
            get { return isError; }
            set { SetProperty(ref isError, value); }
        }

        string displaySort = "";
        public string DisplaySort
        {
            get { return displaySort; }
            set { SetProperty(ref displaySort, value); }
        }

        StationStatusEnum stationStatus = StationStatusEnum.Running;
        public StationStatusEnum StationStatus
        {
            get { return stationStatus; }
            set { SetProperty(ref stationStatus, value); }
        }

        StationStatusEnum stationStatusError = StationStatusEnum.Running;
        public StationStatusEnum StationStatusError
        {
            get { return stationStatusError; }
            set { SetProperty(ref stationStatusError, value); }
        }

    }

    public enum StationStatusEnum
    {
        Unkown = 0,
        Running = 1,
        Warning = 2,
        Error = 4,
    }

}
