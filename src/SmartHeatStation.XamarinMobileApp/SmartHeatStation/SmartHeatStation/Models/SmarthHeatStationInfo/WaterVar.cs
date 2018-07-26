using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStation.Models.ParaInfo
{
    public class WaterVar
    {
        public string 阀开信号 { get; set; } = "N";
        public string 阀关信号 { get; set; } = "N";
        public string 手自动切换信号 { get; set; } = "N";
        public string 复位信号 { get; set; } = "N";
        public string 故障信号 { get; set; } = "N";

        public bool IsVisible { get; set; } = true;

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

    }
}
