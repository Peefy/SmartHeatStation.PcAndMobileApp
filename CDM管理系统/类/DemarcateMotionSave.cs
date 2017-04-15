using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    public class DemarcateMotionSave
    {
        public float FlowDema { get; set; } 
        public int StanPulseCount { get; set; }
        public float StanFlowSum { get; set; }
        public int WorkPulseCount { get; set; } 
        public float WorkFlowSum  { get; set; }
        public float Error { get; set; }
        public float MeterFactor { get; set; }
        public float[] Para 
        {
            get
            {
                return new float[] { FlowDema, StanPulseCount, StanFlowSum, WorkPulseCount,
            WorkFlowSum, Error,MeterFactor};
            }
            set
            {
                FlowDema = value[0];
                StanPulseCount = (int)value[1];
                StanFlowSum = value[2];
                WorkPulseCount = (int)value[3];
                WorkFlowSum = value[4];
                Error = value[5];
                MeterFactor = value[6];
            }
        }
    }
}
