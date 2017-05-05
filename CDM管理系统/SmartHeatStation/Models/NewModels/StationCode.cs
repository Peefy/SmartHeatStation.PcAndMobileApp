using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.SmartHeatStation.Models
{
    public class StationCode
    {
        public static string[] ParaNames =
        {
            //"id",
            "station",
            "used",
            "type",
            "ip",
            "port",
            "addr",
            //"stationtitle",
            "area",
            "dispsort",
            "stop",
            "errsign",
            "alarmsign",
            "waterbox_exist",
            "waterboxheight",
            "waterbox_supply",
            "waterbox_stop",
            "waterbox_up",
            "waterbox_down",
            "stationvisible",

            "sp1visible",
            "lp1visible",
            "st1visible",
            "lt1visible",
            "flow1visible",

             "sp2visible",
            "lp2visible",
            "st2visible",
            "lt2visible",
            "flow2visible",

             "sp3visible",
            "lp3visible",
            "st3visible",
            "lt3visible",
            "flow3visible",

             "sp4visible",
            "lp4visible",
            "st4visible",
            "lt4visible",
            "flow4visible",

            "swpvisible",
            "otvisible",
            "waterboxvisible",
            "fc1visible",
            "fc2visible",
            "fc3visible",
            "fc4visible",
            "fc5visible",
            "fc6visible",
            "fc7visible",
            "fc8visible",
            "fc9visible",
            "fc10visible",
            "fc10_upt",

            "alarm_sp1choose",
            "alarm_sp1sign",
            "alarm_sp1up",
            "alarm_sp1down",
            "alarm_lp1choose",
            "alarm_lp1sign",
            "alarm_lp1up",
            "alarm_lp1down",
            "alarm_st1choose",
            "alarm_st1sign",
            "alarm_st1up",
            "alarm_st1down",
            "alarm_lt1choose",
            "alarm_lt1sign",
            "alarm_lt1up",
            "alarm_lt1down",
            "alarm_flow1choose",
            "alarm_flow1sign",
            "alarm_flow1up",
            "alarm_flow1down",

            "alarm_sp2choose",
            "alarm_sp2sign",
            "alarm_sp2up",
            "alarm_sp2down",
            "alarm_lp2choose",
            "alarm_lp2sign",
            "alarm_lp2up",
            "alarm_lp2down",
            "alarm_st2choose",
            "alarm_st2sign",
            "alarm_st2up",
            "alarm_st2down",
            "alarm_lt2choose",
            "alarm_lt2sign",
            "alarm_lt2up",
            "alarm_lt2down",
            "alarm_flow2choose",
            "alarm_flow2sign",
            "alarm_flow2up",
            "alarm_flow2down",

            "alarm_sp3choose",
            "alarm_sp3sign",
            "alarm_sp3up",
            "alarm_sp3down",
            "alarm_lp3choose",
            "alarm_lp3sign",
            "alarm_lp3up",
            "alarm_lp3down",
            "alarm_st3choose",
            "alarm_st3sign",
            "alarm_st3up",
            "alarm_st3down",
            "alarm_lt3choose",
            "alarm_lt3sign",
            "alarm_lt3up",
            "alarm_lt3down",
            "alarm_flow3choose",
            "alarm_flow3sign",
            "alarm_flow3up",
            "alarm_flow3down",

            "alarm_sp4choose",
            "alarm_sp4sign",
            "alarm_sp4up",
            "alarm_sp4down",
            "alarm_lp4choose",
            "alarm_lp4sign",
            "alarm_lp4up",
            "alarm_lp4down",
            "alarm_st4choose",
            "alarm_st4sign",
            "alarm_st4up",
            "alarm_st4down",
            "alarm_lt4choose",
            "alarm_lt4sign",
            "alarm_lt4up",
            "alarm_lt4down",
            "alarm_flow4choose",
            "alarm_flow4sign",
            "alarm_flow4up",
            "alarm_flow4down",

            "alarm_swpchoose",
            "alarm_swpsign",
            "alarm_swpup",
            "alarm_swpdown",

            "alarm_waterbox",
            "alarm_floorwater",

            "alarm_fc1choose",
            "alarm_fc1sign",
            "alarm_fc1up",
            "alarm_fc1down",

            "alarm_fc2choose",
            "alarm_fc2sign",
            "alarm_fc2up",
            "alarm_fc2down",

            "alarm_fc3choose",
            "alarm_fc3sign",
            "alarm_fc3up",
            "alarm_fc3down",

            "alarm_fc4choose",
            "alarm_fc4sign",
            "alarm_fc4up",
            "alarm_fc4down",

            "alarm_fc5choose",
            "alarm_fc5sign",
            "alarm_fc5up",
            "alarm_fc5down",

            "alarm_fc6choose",
            "alarm_fc6sign",
            "alarm_fc6up",
            "alarm_fc6down",

            "alarm_fc7choose",
            "alarm_fc7sign",
            "alarm_fc7up",
            "alarm_fc7down",

            "alarm_fc8choose",
            "alarm_fc8sign",
            "alarm_fc8up",
            "alarm_fc8down",

            "alarm_fc9choose",
            "alarm_fc9sign",
            "alarm_fc9up",
            "alarm_fc9down",

            "alarm_fc10choose",
            "alarm_fc10sign",
            "alarm_fc10up",
            "alarm_fc10down",

            "exist_devices",
            "exist_devicesint1",
            "exist_devicesint2",
            "exist_devicesint3",
            "exist_devicesint4",

            "exist_sp1",
            "exist_lp1",
            "exist_st1",
            "exist_lt1",
            "exist_flow1",

            "exist_sp2",
            "exist_lp2",
            "exist_st2",
            "exist_lt2",
            "exist_flow2",

            "exist_sp3",
            "exist_lp3",
            "exist_st3",
            "exist_lt3",
            "exist_flow3",

            "exist_sp4",
            "exist_lp4",
            "exist_st4",
            "exist_lt4",
            "exist_flow4",

            "exist_swp",
            "exist_ot",
            "exist_fc1",
            "exist_fc2",
            "exist_fc3",
            "exist_fc4",
            "exist_fc5",
            "exist_fc6",
            "exist_fc7",
            "exist_fc8",
            "exist_fc9",
            "exist_fc10",

            "exist_devices1",

            "grb_hrzhcode",
            "managementid",
            "pipelineid",
            "iscontrol",
            "registearea",
            "actarea",
            "designflow",
            "highpoint",
            "lowpoint",
            "middlepoint",
            "valvemax",
            "valvemin",
            "high_lpmax",
            "high_lpmin",
            "low_lpmax",
            "low_lpmin",
            "middle_lpmax",
            "middle_lpmin",
            "high_pdiff",
            "low_pdiff",
            "high_tdiff",
            "low_tdiff",
            "high_lwdiff",
            "low_lwdiff",
            "temp_slope",
            "temp_compensation",
            "isreport",
            "valvevisible",
            "tempusemeters",
        };

        public Dictionary<string, string> Dictionary { get; set; }

        public StationCode()
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

    }
}
