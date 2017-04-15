using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHeatStationParaInfo
{
    public class Station
    {

        public static string[] NameStrings =
{
            "阿尔滨站",
            "金渤海景站",
            "南山站",
            "金山站",
            "政府站",
            "龙王站",
            "自来水站",
            "南棉站",
            "盐场站",
            "金海国际站",
            "北京郡站",
            "光明西站",
            "金海明珠站",
            "金连领地站",
            "金山名苑站",
            "欧美亚站",
            "铁路站",
            "五一站",
            "于家洼站",
            "环保站",
        };

        public Area 一网 { get; set; }
        public Area 二网高区 { get; set; }
        public Area 二网中区 { get; set; }
        public Area 二网低区 { get; set; }
        public WaterBox 水箱 { get; set; }
        public WaterBox 水箱2 { get; set; }
        public WaterVar 水箱进水阀 { get; set; }
        public AdjustVar 总调节阀 { get; set; }
        public string 流量 { get; set; } = "88.99";
        public string 累积热量 { get; set; } = "123.123"; 
        public Pump[] 泵系列 { get; set; }

        public string Name { get; set; }

        public Station()
        {
            this.一网 = new Area();
            this.二网高区 = new Area();
            this.二网中区 = new Area();
            this.二网低区 = new Area();
            this.水箱 = new WaterBox();
            this.水箱2 = new WaterBox();
            this.水箱进水阀 = new WaterVar();
            this.总调节阀 = new AdjustVar();
            this.泵系列 = new Pump[] {new Pump(), new Pump(), new Pump(), new Pump(), new Pump(),
                new Pump(),new Pump(),new Pump(),new Pump(),new Pump(),};
        }

        public string[] Paras
        {
            set
            {
                this.一网.供水压力.Value = value[0];
                this.一网.供水压力.上限 = value[1];
                this.一网.供水压力.下限 = value[2];

                this.一网.供水温度.Value = value[3];
                this.一网.供水温度.上限 = value[4];
                this.一网.供水温度.下限 = value[5];

                this.一网.回水压力.Value = value[6];
                this.一网.回水压力.上限 = value[7];
                this.一网.回水压力.下限 = value[8];

                this.一网.回水温度.Value = value[9];
                this.一网.回水温度.上限 = value[10];
                this.一网.回水温度.下限 = value[11];

                this.二网高区.供水压力.Value = value[12];
                this.二网高区.供水压力.上限 = value[13];
                this.二网高区.供水压力.下限 = value[14];

                this.二网高区.供水温度.Value = value[15];
                this.二网高区.供水温度.上限 = value[16];
                this.二网高区.供水温度.下限 = value[17];

                this.二网高区.回水压力.Value = value[18];
                this.二网高区.回水压力.上限 = value[19];
                this.二网高区.回水压力.下限 = value[20];

                this.二网高区.回水温度.Value = value[21];
                this.二网高区.回水温度.上限 = value[22];
                this.二网高区.回水温度.下限 = value[23];

                this.二网中区.供水压力.Value = value[24];
                this.二网中区.供水压力.上限 = value[25];
                this.二网中区.供水压力.下限 = value[26];

                this.二网中区.供水温度.Value = value[27];
                this.二网中区.供水温度.上限 = value[28];
                this.二网中区.供水温度.下限 = value[29];

                this.二网中区.回水压力.Value = value[30];
                this.二网中区.回水压力.上限 = value[31];
                this.二网中区.回水压力.下限 = value[32];

                this.二网中区.回水温度.Value = value[33];
                this.二网中区.回水温度.上限 = value[34];
                this.二网中区.回水温度.下限 = value[35];

                this.二网低区.供水压力.Value = value[36];
                this.二网低区.供水压力.上限 = value[37];
                this.二网低区.供水压力.下限 = value[38];

                this.二网低区.供水温度.Value = value[39];
                this.二网低区.供水温度.上限 = value[40];
                this.二网低区.供水温度.下限 = value[41];

                this.二网低区.回水压力.Value = value[42];
                this.二网低区.回水压力.上限 = value[43];
                this.二网低区.回水压力.下限 = value[44];

                this.二网低区.回水温度.Value = value[45];
                this.二网低区.回水温度.上限 = value[46];
                this.二网低区.回水温度.下限 = value[47];

                this.水箱.真实液位高度 = value[48];
                this.水箱.补水位高度 = value[49];
                this.水箱.停水位高度 = value[50];
                this.水箱.上限高度 = value[51];
                this.水箱.下限高度 = value[52];

                this.水箱2.真实液位高度 = value[53];
                this.水箱2.补水位高度 = value[54];
                this.水箱2.停水位高度 = value[55];
                this.水箱2.上限高度 = value[56];
                this.水箱2.下限高度 = value[57];

                this.水箱进水阀.阀开信号 = value[58];
                this.水箱进水阀.阀关信号 = value[59];
                this.水箱进水阀.手自动切换信号 = value[60];
                this.水箱进水阀.复位信号 = value[61];
                this.水箱进水阀.故障信号 = value[62];

                this.总调节阀.设定开度 = value[63];
                this.总调节阀.实际开度 = value[64];
                this.总调节阀.故障信号 = value[65];

                this.流量 = value[66];
                this.累积热量 = value[67];

                this.泵系列[0].频率 = value[68];
                this.泵系列[0].电流 = value[69];
                this.泵系列[0].泵启动 = value[70];
                this.泵系列[0].泵停止 = value[71];
                this.泵系列[0].泵运行 = value[72];
                this.泵系列[0].泵故障 = value[73];
                this.泵系列[0].通信故障 = value[74];
                this.泵系列[0].远程控制 = value[75];

                this.泵系列[1].频率 = value[76];
                this.泵系列[1].电流 = value[77];
                this.泵系列[1].泵启动 = value[78];
                this.泵系列[1].泵停止 = value[79];
                this.泵系列[1].泵运行 = value[80];
                this.泵系列[1].泵故障 = value[81];
                this.泵系列[1].通信故障 = value[82];
                this.泵系列[1].远程控制 = value[83];

                this.泵系列[2].频率 = value[84];
                this.泵系列[2].电流 = value[85];
                this.泵系列[2].泵启动 = value[86];
                this.泵系列[2].泵停止 = value[87];
                this.泵系列[2].泵运行 = value[88];
                this.泵系列[2].泵故障 = value[89];
                this.泵系列[2].通信故障 = value[90];
                this.泵系列[2].远程控制 = value[91];

                this.泵系列[3].频率 = value[92];
                this.泵系列[3].电流 = value[93];
                this.泵系列[3].泵启动 = value[94];
                this.泵系列[3].泵停止 = value[95];
                this.泵系列[3].泵运行 = value[96];
                this.泵系列[3].泵故障 = value[97];
                this.泵系列[3].通信故障 = value[98];
                this.泵系列[3].远程控制 = value[99];

                this.泵系列[4].频率 = value[100];
                this.泵系列[4].电流 = value[101];
                this.泵系列[4].泵启动 = value[102];
                this.泵系列[4].泵停止 = value[103];
                this.泵系列[4].泵运行 = value[104];
                this.泵系列[4].泵故障 = value[105];
                this.泵系列[4].通信故障 = value[106];
                this.泵系列[4].远程控制 = value[107];

                this.泵系列[5].频率 = value[108];
                this.泵系列[5].电流 = value[109];
                this.泵系列[5].泵启动 = value[110];
                this.泵系列[5].泵停止 = value[111];
                this.泵系列[5].泵运行 = value[112];
                this.泵系列[5].泵故障 = value[113];
                this.泵系列[5].通信故障 = value[114];
                this.泵系列[5].远程控制 = value[115];

                this.泵系列[6].频率 = value[116];
                this.泵系列[6].电流 = value[117];
                this.泵系列[6].泵启动 = value[118];
                this.泵系列[6].泵停止 = value[119];
                this.泵系列[6].泵运行 = value[120];
                this.泵系列[6].泵故障 = value[121];
                this.泵系列[6].通信故障 = value[122];
                this.泵系列[6].远程控制 = value[123];

                this.泵系列[7].频率 = value[124];
                this.泵系列[7].电流 = value[125];
                this.泵系列[7].泵启动 = value[126];
                this.泵系列[7].泵停止 = value[127];
                this.泵系列[7].泵运行 = value[128];
                this.泵系列[7].泵故障 = value[129];
                this.泵系列[7].通信故障 = value[130];
                this.泵系列[7].远程控制 = value[131];

                this.泵系列[8].频率 = value[132];
                this.泵系列[8].电流 = value[133];
                this.泵系列[8].泵启动 = value[134];
                this.泵系列[8].泵停止 = value[135];
                this.泵系列[8].泵运行 = value[136];
                this.泵系列[8].泵故障 = value[137];
                this.泵系列[8].通信故障 = value[138];
                this.泵系列[8].远程控制 = value[139];

                this.泵系列[9].频率 = value[140];
                this.泵系列[9].电流 = value[141];
                this.泵系列[9].泵启动 = value[142];
                this.泵系列[9].泵停止 = value[143];
                this.泵系列[9].泵运行 = value[144];
                this.泵系列[9].泵故障 = value[145];
                this.泵系列[9].通信故障 = value[146];
                this.泵系列[9].远程控制 = value[147];


            }
        }

        public void SetAllParaNull()
        {
            var strs = new string[148];
            for (int i = 0; i < strs.Length; ++i)
                strs[i] = "N";
            Paras = strs;
            
        }

        public bool IsNormal
        {
            get
            {
                return this.一网.IsNormal && this.二网高区.IsNormal && this.二网中区.IsNormal
                  && this.二网低区.IsNormal;
            }
        }

        public bool IsError
        {
            get
            {
                return this.水箱.IsError || this.水箱2.IsError || this.水箱进水阀.IsError ||
                    this.总调节阀.IsError || this.泵系列[0].IsError || this.泵系列[1].IsError ||
                    this.泵系列[2].IsError || this.泵系列[3].IsError || this.泵系列[4].IsError ||
                    this.泵系列[5].IsError || this.泵系列[6].IsError || this.泵系列[7].IsError ||
                    this.泵系列[8].IsError || this.泵系列[9].IsError;
            }
        }

        public string WhichIsNotNormal
        {
            get
            {
                string str = "";
                str += (this.一网.IsNormal == true ? "" : "一次网报警，");
                str += (this.二网高区.IsNormal == true ? "" : "二网高区报警，");
                str += (this.二网中区.IsNormal == true ? "" : "二网中区报警，");
                str += (this.二网低区.IsNormal == true ? "" : "二网低区报警，");
                return str;

            }
        }

        public string WhichIsError
        {
            get
            {
                string str = "";
                str += (this.水箱.IsError == true ? "水箱1故障，" : "");
                str += (this.水箱2.IsError == true ? "水箱2故障，" : "");
                str += (this.水箱进水阀.IsError == true ? "水箱进水阀故障，" : "");
                str += (this.总调节阀.IsError == true ? "总调节阀故障，" : "");
                for (int i = 0; i < this.泵系列.Length; ++i)
                {
                    str += (this.泵系列[i].IsError == true ? string.Format("泵{0}故障，", i) : "");
                }
                return str;
            }
        }

        public override string ToString()
        {
            string str = this.一网.ToString() +
            this.二网高区.ToString() +
            this.二网中区.ToString() +
            this.二网低区.ToString() +
            this.水箱.ToString() +
            this.水箱2.ToString() +
            this.水箱进水阀.ToString() +
            this.总调节阀.ToString() +
            this.流量 + "|" + this.累积热量 + "|";
            foreach (Pump pump in this.泵系列)
            {
                str += pump.ToString();
            }
            return str;
        }

    }
}
