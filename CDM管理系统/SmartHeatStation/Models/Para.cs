using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
{
    public class Para
    {
        public string 上限 { get; set; } = "1.2";
        public string 下限 { get; set; } = "0.4";
        public string Value { get; set; } = "0.88";

        public bool IsNormal
        {
            get
            {

                if (this.Value== "N")
                    return true;

                try
                {
                    float up = float.Parse(this.上限);
                    float down = float.Parse(this.下限);
                    float value = float.Parse(this.Value);
                    if (value < up && value > down)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }

        public override string ToString()
        {
            return this.Value + "|" +
              this.上限 + "|" +
              this.下限 + "|";
        }

    }
}
