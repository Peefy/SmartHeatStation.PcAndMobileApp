using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    public class DemarcateMotion                                                     
    {
        float val;
        public float FlowDema { get; set; } = 123.456f;
        public int StanPulseCount { get; set; } = 50000;
        public float StanFlowSum { get {
                if(FlowMeterStadardPara != null)
                return StanPulseCount * FlowMeterStadardPara[9];
                return 66666;
            }
            private set { val = value; }
        }
        public int WorkPulseCount { get; set; } = 50000;
        public float WorkFlowSum { get {
                if(FlowMeterWorkPara!= null)
                return WorkPulseCount * FlowMeterWorkPara[9];
                return 66666;
            }
            private set { val = value; }
        } 
        public float Error
        {
            get { return -0.01f; }
            private set { val = value; }
        }
        public float MeterFactor
        {
            get { return StanFlowSum / WorkFlowSum; }
            private set { val = value; }
        }

        public float[] Para
        {
            get { return new float[] { FlowDema, StanPulseCount, StanFlowSum, WorkPulseCount,
            WorkFlowSum, Error,MeterFactor}; }

        }
        public static float[] FlowMeterWorkPara;
        public static float[] FlowMeterStadardPara;

        public static float GetMeterFactorAverange(DemarcateMotion[] demaArray)
        {
            float sum = 0;
            foreach(DemarcateMotion dema in demaArray)
            {
                sum += dema.MeterFactor;
            }
            return sum / demaArray.Length;
        }

    }
}
