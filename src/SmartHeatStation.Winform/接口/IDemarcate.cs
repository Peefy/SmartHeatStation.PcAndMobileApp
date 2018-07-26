using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    interface IDemarcate
    {

        bool IsAutoMode { get; set; }

        int Count { get; set; }
        int Time { get; set; }
        int Interval { get; set; }

        int CountShow { get; set; }
        int TimeUsePerCount { get; set; }

        bool Start { get; set; }
        bool Stop { get; set; }
        bool Test { get; set; }
        bool TestStop { get; set; }
        bool OpenPort { get; set; }

        bool IsING { get; set; }

    }
}
