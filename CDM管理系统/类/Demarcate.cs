using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    class Demarcate : IDemarcate
    {

        const int minCount = 1;
        const int maxCount = 12;
        const int minTime = 1;
        const int maxTime = 10;
        const int minInterval = 1;
        const int maxInterval = 10;
        
        private int count = 5;

        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool Test { get; set; }
        public bool TestStop { get; set; }
        public bool OpenPort { get; set; }

        public bool IsING { get; set; }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value >= maxCount) count = maxCount;
                else if (value <= minCount) count = minCount;
                else count = value;
            }
        }
        public int CountShow { get; set; }
        public int Interval { get; set; } = minInterval;
        public bool IsAutoMode { get; set; } = true;
        public int Time { get; set; } = minTime;
        public int TimeUsePerCount { get; set; }
        public bool ClearCountShow { get; set; }

        public string SocketConnectIPstring { get; set; } = "192.168.1.21";

    }
}
