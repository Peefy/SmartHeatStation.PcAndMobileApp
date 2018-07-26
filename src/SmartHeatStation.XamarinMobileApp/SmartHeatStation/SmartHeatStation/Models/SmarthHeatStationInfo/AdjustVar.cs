using System;
using System.Collections.Generic;
using System.Text;


namespace SmartHeatStation.Models.ParaInfo
{
    public class AdjustVar
    {
        public string 设定开度 { get; set; } = "N";
        public string 实际开度 { get; set; } = "N";
        public string 故障信号 { get; set; } = "N";

        public override string ToString()
        {
            return this.设定开度 + "|" +
              this.实际开度 + "|" +
              this.故障信号 + "|";
        }

        public bool IsVisible { get; set; } = true;

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
