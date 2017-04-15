using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
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

        public string[] ParaValues
        {
            get
            {
                return new string[] 
                {
                    this.供水压力.Value,
                    this.供水压力.上限,
                    this.供水压力.下限,

                    this.供水温度.Value,
                    this.供水温度.上限,
                    this.供水温度.下限,

                    this.回水压力.Value,
                    this.回水压力.上限,
                    this.回水压力.下限,

                    this.回水温度.Value,
                    this.回水温度.上限,
                    this.回水温度.下限,
                };
            }
            set
            {
                this.供水压力.Value = value[0];
                this.供水压力.上限 = value[1];
                this.供水压力.下限 = value[2];

                this.供水温度.Value = value[3];
                this.供水温度.上限 = value[4];
                this.供水温度.下限 = value[5];

                this.回水压力.Value = value[6];
                this.回水压力.上限 = value[7];
                this.回水压力.下限 = value[8];

                this.回水温度.Value = value[9];
                this.回水温度.上限 = value[10];
                this.回水温度.下限 = value[11];
            }
        }

        public string[] ParaNames
        {
            get
            {
                return new string[]
                {
                    "供水压力当前值",
                    "供水压力上限值",
                    "供水压力下限值",

                    "供水温度当前值",
                    "供水温度上限值",
                    "供水温度下限值",

                    "回水压力当前值",
                    "回水压力上限值",
                    "回水压力下限值",

                    "回水温度当前值",
                    "回水温度上限值",
                    "回水温度下限值",
                };
            }
        }

    }
}
