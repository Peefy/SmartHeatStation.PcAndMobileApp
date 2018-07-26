using System;
using System.Collections.Generic;
using System.Text;


namespace SmartHeatStationParaInfo
{
    public class AdjustVar
    {
        public string 设定开度 { get; set; } = "45";
        public string 实际开度 { get; set; } = "44.4";
        public string 故障信号 { get; set; } = "0";

        public override string ToString()
        {
            return this.设定开度 + "|" +
              this.实际开度 + "|" +
              this.故障信号 + "|";
        }

        public bool IsError
        {
            get
            {

                if (this.故障信号 == "N")
                    return false;

                try
                {
                    if (this.故障信号 != "0")
                        return true;
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public string[] ParaValues
        {
            get
            {
                return new string[]
                {
                    this.设定开度,
                    this.实际开度,
                    this.故障信号,
                };
            }
            set
            {
                this.设定开度 = value[0];
                this.实际开度 = value[1];
                this.故障信号 = value[2];
            }
        }

        public string[] ParaNames
        {
            get
            {
                return new string[]
                {
                    "设定开度",
                    "实际开度",
                    "故障信号",
                };
            }
        }

    }
}
