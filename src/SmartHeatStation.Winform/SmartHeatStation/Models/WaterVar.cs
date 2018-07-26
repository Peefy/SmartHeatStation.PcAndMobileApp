using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
{
    public class WaterVar
    {
        public string 阀开信号 { get; set; } = "1";
        public string 阀关信号 { get; set; } = "0";
        public string 手自动切换信号 { get; set; } = "0";
        public string 复位信号 { get; set; } = "0";
        public string 故障信号 { get; set; } = "0";

        public override string ToString()
        {
            return this.阀开信号 + "|" +
                this.阀关信号 + "|" +
                this.手自动切换信号 + "|" +
                this.复位信号 + "|" +
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
                    this.阀开信号,
                    this.阀关信号,
                    this.手自动切换信号,
                    this.复位信号,
                    this.故障信号,
                };
            }
            set
            {
                this.阀开信号 = value[0];
                    this.阀关信号 = value[1];
                this.手自动切换信号 = value[2];

                this.复位信号 = value[3];
                this.故障信号 = value[4];
            }
        }

        public string[] ParaNames
        {
            get
            {
                return new string[]
                {
                    "阀开信号",
                    "阀关信号",
                    "手自动切换信号",

                    "复位信号",
                    "故障信号",

                };
            }
        }

    }
}
