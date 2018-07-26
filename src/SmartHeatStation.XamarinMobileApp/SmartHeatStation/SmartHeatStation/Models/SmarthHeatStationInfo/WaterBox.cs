using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStation.Models.ParaInfo
{
    public class WaterBox
    {
        public string 真实液位高度 { get; set; } = "N";
        public string 补水位高度 { get; set; } = "N";
        public string 停水位高度 { get; set; } = "N";
        public string 上限高度 { get; set; } = "N";
        public string 下限高度 { get; set; } = "N";

        public bool IsVisible { get; set; } = true;

        public override string ToString()
        {
            return this.真实液位高度 + "|" +
              this.补水位高度 + "|" +
              this.停水位高度 + "|" +
              this.上限高度 + "|" +
              this.下限高度 + "|";
        }

        public bool IsError
        {
            get
            {

                if (this.真实液位高度 == "N")
                    return false;

                try
                {
                    float realHeight = float.Parse(this.真实液位高度);
                    float up = float.Parse(this.上限高度);
                    float down = float.Parse(this.下限高度);
                    if (realHeight > up || realHeight < down)
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
