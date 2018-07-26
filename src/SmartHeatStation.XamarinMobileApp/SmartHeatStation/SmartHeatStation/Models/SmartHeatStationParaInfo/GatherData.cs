using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeatStation.Models.ParaInfo
{
    public class GatherData
    {

        public static string[] ParaNames =
        {
             "stationid",//站id
             "gathertime",//采集时间
             "num_sp1",//一次供压
             "num_lp1",//一次回压
             "num_st1",//一次供温
             "num_lt1",//一次回温
             "num_flow1",//一次流量
             "num_sp2",//二次低区供压
             "num_lp2",//二次低区回压
             "num_st2",//二次低区供温
             "num_lt2",//二次低区回温
             "num_flow2",//二次低区流量
             "num_sp3",//
             "num_lp3",//
             "num_st3",//
             "num_lt3",//
             "num_flow3",//
             "num_sp4",//
             "num_lp4",//
             "num_st4",//
             "num_lt4",//
             "num_flow4",//
             "num_swp",//
             "num_waterboxheight",//
             "num_waterposition",//
             "num_ot",//??
             "num_fc1",//
             "num_fc2",//
             "num_fc3",//
             "num_fc4",//
             "num_fc5",//
             "num_fc6",//

             "num_fc1_f",//
             "num_fc2_f",//
             "num_fc3_f",//
             "num_fc4_f",//
             "num_fc5_f",//
             "num_fc6_f",//

             "num_fc1_s",//
             "num_fc2_s",//
             "num_fc3_s",//
             "num_fc4_s",//
             "num_fc5_s",//
             "num_fc6_s",//

             "num_fc1_c",//
             "num_fc2_c",//
             "num_fc3_c",//
             "num_fc4_c",//
             "num_fc5_c",//
             "num_fc6_c",//

             "num_fc7_f",//
             "num_fc8_f",//
             "num_fc9_f",//
             "num_fc10_f",//

             "num_elec",//??
             "num_watermeter",//??
             "stop",//
             "alarmsign",//
             "errsign" ,//
             "linksign",//
             "alarmreason" ,//
             "errreason" ,//

             "IP",//
             "port",//
             "fullstr",//

             "alarm_sp1sign",//
             "alarm_lp1sign",//
             "alarm_st1sign",//
             "alarm_lt1sign",//
             "alarm_flow1sign",//

              "alarm_sp2sign",//
             "alarm_lp2sign",//
             "alarm_st2sign",//
             "alarm_lt2sign",//
             "alarm_flow2sign",//

              "alarm_sp3sign",//
             "alarm_lp3sign",//
             "alarm_st3sign",//
             "alarm_lt3sign",//
             "alarm_flow3sign",//
             
              "alarm_sp4sign",//
             "alarm_lp4sign",//
             "alarm_st4sign",//
             "alarm_lt4sign",//
             "alarm_flow4sign",//

             "alarm_floorwater",//??

             "alarm_fc1sign",//
             "alarm_fc2sign",//
             "alarm_fc3sign",//
             "alarm_fc4sign",//
             "alarm_fc5sign",//
             "alarm_fc6sign",//
             "alarm_fc7sign",//
             "alarm_fc8sign",//
             "alarm_fc9sign",//
             "alarm_fc10sign",//
             "alarm_waterbox",//
             
             "errsign_work1",//
             "errsign_work2",//
             "errsign_lose1",//
             "errsign_lose2",//
             "errsign_lose3",//
             "errsign_lose4",//
             "errsign_failure1",//
             "errsign_failure2",//
             "errsign_new",//
             "alarmsign_new",//
             "sumheat",//
             "sumflow",//

             "intemp",//
             "outtemp",//
             "valvepercent",//
             "sumheat2",//
             "sumflow2",//
             "intemp2",//
             "outtemp2",//
             "num_heat1",//

        };

        public static string[] ParaNamesChinese =
        {
            "站Id",
            "采集时间",

            "一次供压",
            "一次回压",
            "一次供温",
            "一次回温",
            "一次流量",

            "二次低区供压",
            "二次低区回压",
            "二次低区供温",
            "二次低区回温",
            "二次低区流量",

            "二次中区供压",
            "二次中区回压",
            "二次中区供温",
            "二次中区回温",
            "二次中区流量",

            "二次高区供压",
            "二次高区回压",
            "二次高区供温",
            "二次高区回温",
            "二次高区流量",

            "swp...",
            "水箱高度",
            "水箱位置",
            "ot",
            "fc1",
            "fc2",
            "fc3",
            "fc4",
            "fc5",
            "fc6",

            "变频控制1_频率",
            "变频控制2_频率",
            "变频控制3_频率",
            "变频控制4_频率",
            "变频控制5_频率",
            "变频控制6_频率",

            "变频控制1_转速",
            "变频控制2_转速",
            "变频控制3_转速",
            "变频控制4_转速",
            "变频控制5_转速",
            "变频控制6_转速",

            "变频控制1_电流",
            "变频控制2_电流",
            "变频控制3_电流",
            "变频控制4_电流",
            "变频控制5_电流",
            "变频控制6_电流",

            "变频控制7_频率",
            "变频控制8_频率",
            "变频控制9_频率",
            "变频控制10_频率",

            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
            "站Id",
        };
        public string[] Paras
        {
            set
            {
                for(int i = 0;i<ParaNames.Length - 1 ;++i)
                {
                    Dictionary[ParaNames[i]] = value[i];
                }
            }
        }

        public Dictionary<string, string> Dictionary { get; set; }

        public GatherData()
        {
            Dictionary = new Dictionary<string, string>();
            foreach (var name in ParaNames)
            {
                Dictionary.Add(name, "");
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (var name in ParaNames)
            {
                str += (Dictionary[name] + "|");
            }
            return str;
        }

        public string AlarmReason
        {
            get
            {
                string str = "";

                #region 一次网
                if(Dictionary["alarm_sp1sign"] == "True")
                {
                    str += "一次网供水压力报警;";
                }
                if (Dictionary["alarm_lp1sign"] == "True")
                {
                    str += "一次网回水压力报警;";
                }
                if (Dictionary["alarm_st1sign"] == "True")
                {
                    str += "一次网供水温度报警;";
                }
                if (Dictionary["alarm_lt1sign"] == "True")
                {
                    str += "一次网回水温度报警;";
                }
                if (Dictionary["alarm_flow1sign"] == "True")
                {
                    str += "一次网流量报警;";
                }
                #endregion
                #region 二次低区
                if (Dictionary["alarm_sp2sign"] == "True")
                {
                    str += "二次低区供水压力报警;";
                }
                if (Dictionary["alarm_lp2sign"] == "True")
                {
                    str += "二次低区回水压力报警;";
                }
                if (Dictionary["alarm_st2sign"] == "True")
                {
                    str += "二次低区供水温度报警;";
                }
                if (Dictionary["alarm_lt2sign"] == "True")
                {
                    str += "二次低区回水温度报警;";
                }
                if (Dictionary["alarm_flow2sign"] == "True")
                {
                    str += "二次低区流量报警;";
                }
                #endregion
                #region 二次中区
                if (Dictionary["alarm_sp3sign"] == "True")
                {
                    str += "二次中区供水压力报警;";
                }
                if (Dictionary["alarm_lp3sign"] == "True")
                {
                    str += "二次中区回水压力报警;";
                }
                if (Dictionary["alarm_st3sign"] == "True")
                {
                    str += "二次中区供水温度报警;";
                }
                if (Dictionary["alarm_lt3sign"] == "True")
                {
                    str += "二次中区回水温度报警;";
                }
                if (Dictionary["alarm_flow3sign"] == "True")
                {
                    str += "二次中区流量报警;";
                }
                #endregion
                #region 二次高区
                if (Dictionary["alarm_sp4sign"] == "True")
                {
                    str += "二次高区供水压力报警;";
                }
                if (Dictionary["alarm_lp4sign"] == "True")
                {
                    str += "二次高区回水压力报警;";
                }
                if (Dictionary["alarm_st4sign"] == "True")
                {
                    str += "二次高区供水温度报警;";
                }
                if (Dictionary["alarm_lt4sign"] == "True")
                {
                    str += "二次高区回水温度报警;";
                }
                if (Dictionary["alarm_flow4sign"] == "True")
                {
                    str += "二次高区流量报警;";
                }
                #endregion
                #region 补水压力设备

                if (Dictionary["alarm_floorwater"] == "True")
                {
                    str += "补水压力设备报警;";
                }

                #endregion
                #region 水箱

                if (Dictionary["alarm_waterbox"] == "True")
                {
                    str += "水箱报警;";
                }

                #endregion
                #region 变频控制

                for(int i = 1;i<=10 ;++i)
                {
                    if (Dictionary[$"alarm_fc{i}sign"] == "True")
                    {
                        str += $"变频控制{i}报警;";
                    }
                }

                #endregion
                return str;
            }
        }

        public string ErrorReason
        {
            get
            {
                string str = "";
                return str;
            }
        }

    }
}
