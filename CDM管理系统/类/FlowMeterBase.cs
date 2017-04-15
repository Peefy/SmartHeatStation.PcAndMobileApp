using System;

namespace 流量计检定上位机
{
    abstract class FlowMeterBase
    {
        public float FCF { get; set; } = 0.2f;
        public float D1 { get; set; } = 0;
        public float K1 { get; set; } = 0.3f;
        public float D2 { get; set; } = 1;
        public float K2 { get; set; }
        public float DT { get; set; }
        public float MassFlowCoefficient { get; set; }
        public float OutputFrequencyCoefficient { get; set; }
        public float OutputFlowCoefficient { get; set; } = 1;
        public float FlowPulseCoefficient
        {
            set
            {
                if (Math.Abs(OutputFlowCoefficient) > 0)
                    value = OutputFrequencyCoefficient * 3600 / OutputFlowCoefficient;
                else
                    value = 0;
            }
            get
            {
                return OutputFrequencyCoefficient * 3600 / OutputFlowCoefficient;
            }
        }

        public virtual string KindName { get; set; } = "基类表";

        public bool ConnectNormal { get; set; }
        public bool ConnectError { get; set; }

        public float[] DataZhenDuan = new float[10];
        public float Flow { get { return PulseCount * FlowPulseCoefficient; } } 
        public int PulseCount { get; set; } = 99999;
        public float FlowSum {
            get
            { return PulseCount * FlowPulseCoefficient; }
        }

        public float[] Para
        {
            get
            {
                float[] para = { FCF,D1,K1,D2,K2,DT,MassFlowCoefficient,
                    OutputFrequencyCoefficient,
                    OutputFlowCoefficient,
                    FlowPulseCoefficient
                };
                return para;
            }
            set
            {
                FCF = value[0];
                D1 = value[1];
                K1 = value[2];
                D2 = value[3];
                K2 = value[4];
                DT = value[5];
                MassFlowCoefficient = value[6];
                OutputFrequencyCoefficient = value[7];
                OutputFlowCoefficient = value[8];
                FlowPulseCoefficient = value[9];
            }
        }

    }
    
}
