using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM
{
    class MiDuData
    {
        public DateTime Time { get; set; }
        public float Data { get; set; }
        public static List<MiDuData> List = new List<MiDuData>();

        public MiDuData(DateTime time,float data)
        {
            Time = time;
            Data = data;
        }

    }
}
