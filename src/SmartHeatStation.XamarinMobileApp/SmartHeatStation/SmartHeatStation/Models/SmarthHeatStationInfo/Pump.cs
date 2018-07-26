using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStation.Models.ParaInfo
{
    public class Pump
    {
        public string 频率 { get; set; } = "N";
        public string 电流 { get; set; } = "N";
        public string 泵启动 { get; set; } = "N";
        public string 泵停止 { get; set; } = "N";
        public string 泵运行 { get; set; } = "N";
        public string 泵故障 { get; set; } = "N";
        public string 通信故障 { get; set; } = "N";
        public string 远程控制 { get; set; } = "N";

        public bool IsVisible { get; set; } = true;

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

    }
}
