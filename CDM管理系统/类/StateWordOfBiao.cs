namespace 流量计检定上位机
{
    class StateWordOfBiao
    {

        public static ushort ServerCom { get; set; }
        public static ushort SerialInit { get; set; } 
        public static ushort FlowMeterWork { get; set; } 
        public static ushort FlowMeterStadard { get; set; }

        public static int SerialInitNormal { get; set; }
        public static int SerialInitError { get; set; }
        //public static int SerialInitNormal { get; set; }

        public static string GetStatus(Modbus.ModbusTCPMaster MBmaster)
        {
            string strServerCom = "无数据";
            string strSerialInit = "无数据";
            string strFlowMeterWork = "无数据";
            string strFlowMeterStadard = "无数据";

            if(MBmaster?.Connected == true)
            {
                switch (ServerCom)
                {
                    case 0x9999:
                        strServerCom = "正常"; break;
                }
                if(SerialInitNormal == 1)
                {
                    switch (SerialInit)
                    {
                        case 0x0000:
                            strSerialInit = "成功"; break;
                        case 0x8180:
                            strSerialInit = "端口ID无效"; break;
                        case 0x8181:
                            strSerialInit = "波特率值无效"; break;
                        case 0x8182:
                            strSerialInit = "奇偶校验值无效"; break;
                    }
                }
                else
                {
                    strSerialInit = "没打开";
                }

                switch (FlowMeterWork)
                {
                    case 0x0000:
                        strFlowMeterWork = "正常"; break;
                    case 0x80c8:
                        strFlowMeterWork = "从站超时"; break;
                    case 0x8180:
                        strFlowMeterWork = "端口ID无效"; break;
                    case 0x8186:
                        strFlowMeterWork = "Modbus 站地址无效"; break;
                    case 0x8189:
                        strFlowMeterWork = "数据地址值无效"; break;
                    case 0x818a:
                        strFlowMeterWork = "数据长度值无效"; break;
                }

                switch (FlowMeterStadard)
                {
                    case 0x0000:
                        strFlowMeterWork = "正常"; break;
                    case 0x80c8:
                        strFlowMeterWork = "从站超时"; break;
                    case 0x8180:
                        strFlowMeterWork = "端口ID无效"; break;
                    case 0x8186:
                        strFlowMeterWork = "Modbus 站地址无效"; break;
                    case 0x8189:
                        strFlowMeterWork = "数据地址值无效"; break;
                    case 0x818a:
                        strFlowMeterWork = "数据长度值无效"; break;
                }
            }

            return "服务器通信状态:" + strServerCom + " ;初始化串口状态:" + strSerialInit + " ;\r\n" +
                "工作表通信状态:" + strFlowMeterWork + " ;标准表通信状态:" + strFlowMeterStadard;
        }

    }
}
