using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
{
    public class Pump
    {
        public string 频率 { get; set; } = "45";
        public string 电流 { get; set; } = "123";
        public string 泵启动 { get; set; } = "1";
        public string 泵停止 { get; set; } = "0";
        public string 泵运行 { get; set; } = "1";
        public string 泵故障 { get; set; } = "0";
        public string 通信故障 { get; set; } = "0";
        public string 远程控制 { get; set; } = "0";

        public override string ToString()
        {
            return this.频率 + "|" +
              this.电流 + "|" +
              this.泵启动 + "|" +
              this.泵停止 + "|" +
              this.泵运行 + "|" +
              this.泵故障 + "|" +
              this.通信故障 + "|" +
              this.远程控制 + "|";
        }

        public bool IsError
        {
            get
            {

                if (this.泵故障 == "N" || this.通信故障 == "N")
                    return false;

                try
                {
                    if (this.泵故障 != "0" || this.通信故障 != "0")
                        return true;
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool IsRunError
        {
            get
            {

                if (this.泵故障 == "N" )
                    return false;

                try
                {
                    if (this.泵故障 != "0" )
                        return true;
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool IsComError
        {
            get
            {

                if ( this.通信故障 == "N")
                    return false;

                try
                {
                    if ( this.通信故障 != "0")
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
                    this.频率,
                    this.电流,
                    this.泵启动,

                    this.泵停止,
                    this.泵运行,
                    this.泵故障,

                    this.通信故障,
                    this.远程控制,
                };
            }
            set
            {
                this.频率 = value[0];
                this.电流 = value[1];
                this.泵启动 = value[2];

                this.泵停止 = value[3];
                this.泵运行 = value[4];
                this.泵故障 = value[5];

                this.通信故障 = value[6];
                this.远程控制 = value[7];
            }
        }

        public string[] ParaNames
        {
            get
            {
                return new string[]
                {
                    "频率",
                    "电流",
                    "泵启动",

                    "泵停止",
                    "泵运行",
                    "泵故障",

                    "泵通信故障",
                    "泵远程控制",

                };
            }
        }

    }
}
