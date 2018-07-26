using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStation.Models.ParaInfo
{
    public class Area
    {
        public Para 供水压力 { get; set; } 

        public Para 供水温度 { get; set; }

        public Para 回水压力 { get; set; }

        public Para 回水温度 { get; set; }

        public Area()
        {
            this.供水压力 = new Para();
            this.供水温度 = new Para();
            this.回水压力 = new Para();
            this.回水温度 = new Para();
        }

        public bool IsVisible { get; set; } = true;

        public bool IsNormal
        {
            get
            {
                return (this.供水压力.IsNormal == true && this.供水温度.IsNormal == true
                    && this.回水压力.IsNormal == true && this.回水温度.IsNormal == true);
            }
        }

        public override string ToString()
        {
            return this.供水压力.ToString() +
                this.供水温度.ToString() +
                this.回水压力.ToString()  +
                this.回水温度.ToString();
        }

    }
}
