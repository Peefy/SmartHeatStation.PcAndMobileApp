namespace 流量计检定上位机
{
    class FlowMeterWork : FlowMeterBase
    {

        public FlowMeterWork()
        {
            OutputFrequencyCoefficient = 2;
            OutputFlowCoefficient = 22222;
        }

        public override string KindName
        {
            get
            {
                return "工作表";
            }

            set
            {
                base.KindName = value;
            }
        }
    }
}
