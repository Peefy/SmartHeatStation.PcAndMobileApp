namespace 流量计检定上位机
{
    class FlowMeterStandard : FlowMeterBase, IFlowMeterStadard
    {

        public FlowMeterStandard()
        {
            OutputFrequencyCoefficient = 1;
            OutputFlowCoefficient = 11111;
        }

        public float Current { get; set; } = 999;
        public override string KindName 
        {
            get
            {
                return "标准表";
            }

            set
            {
                base.KindName = value;
            }
        }

    }
}
