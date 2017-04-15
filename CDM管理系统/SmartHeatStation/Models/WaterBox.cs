using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
{
    public class WaterBox
    {
        public string 真实液位高度 { get; set; } = "160";
        public string 补水位高度 { get; set; } = "80";
        public string 停水位高度 { get; set; } = "200";
        public string 上限高度 { get; set; } = "220";
        public string 下限高度 { get; set; } = "40";

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

        public string[] ParaValues
        {
            get
            {
                return new string[]
                {
                    this.真实液位高度,
                    this.补水位高度,
                    this.停水位高度,

                    this.上限高度,
                    this.下限高度,
                };
            }
            set
            {
                this.真实液位高度 = value[0];
                this.补水位高度 = value[1];
                this.停水位高度 = value[2];

                this.上限高度 = value[3];
                this.下限高度 = value[4];
            }
        }

        public string[] ParaNames
        {
            get
            {
                return new string[]
                {
                    "真实液位高度",
                    "补水位高度",
                    "停水位高度",

                    "上限高度",
                    "下限高度",

                };
            }
        }

    }
}
