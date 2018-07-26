using System.Collections.Generic;

namespace SmartHeatStationService.Models
{
    public class GatherData
    {

        public static string[] ParaNames =
        {
             "stationid",
             "gathertime",
             "num_sp1",
             "num_lp1",
             "num_st1",
             "num_lt1",
             "num_flow1",
             "num_sp2",
             "num_lp2",
             "num_st2",
             "num_lt2",
             "num_flow2",
             "num_sp3",
             "num_lp3",
             "num_st3",
             "num_lt3",
             "num_flow3",
             "num_sp4",
             "num_lp4",
             "num_st4",
             "num_lt4",
             "num_flow4",
             "num_swp",
             "num_waterboxheight",
             "num_waterposition",
             "num_ot",
             "num_fc1",
             "num_fc2",
             "num_fc3",
             "num_fc4",
             "num_fc5",
             "num_fc6",

             "num_fc1_f",
             "num_fc2_f",
             "num_fc3_f",
             "num_fc4_f",
             "num_fc5_f",
             "num_fc6_f",

             "num_fc1_s",
             "num_fc2_s",
             "num_fc3_s",
             "num_fc4_s",
             "num_fc5_s",
             "num_fc6_s",

             "num_fc1_c",
             "num_fc2_c",
             "num_fc3_c",
             "num_fc4_c",
             "num_fc5_c",
             "num_fc6_c",

             "num_fc7_f",
             "num_fc8_f",
             "num_fc9_f",
             "num_fc10_f",

             "num_elec",
             "num_watermeter" ,
             "stop",
             "alarmsign" ,
             "errsign" ,
             "linksign",
             "alarmreason" ,
             "errreason" ,

             "IP",
             "port",
             "fullstr",

             "alarm_sp1sign",
             "alarm_lp1sign",
             "alarm_st1sign",
             "alarm_lt1sign",
             "alarm_flow1sign",

              "alarm_sp2sign",
             "alarm_lp2sign",
             "alarm_st2sign",
             "alarm_lt2sign",
             "alarm_flow2sign",

              "alarm_sp3sign",
             "alarm_lp3sign",
             "alarm_st3sign",
             "alarm_lt3sign",
             "alarm_flow3sign",

              "alarm_sp4sign",
             "alarm_lp4sign",
             "alarm_st4sign",
             "alarm_lt4sign",
             "alarm_flow4sign",

             "alarm_floorwater",

             "alarm_fc1sign",
             "alarm_fc2sign",
             "alarm_fc3sign",
             "alarm_fc4sign",
             "alarm_fc5sign",
             "alarm_fc6sign",
             "alarm_fc7sign",
             "alarm_fc8sign",
             "alarm_fc9sign",
             "alarm_fc10sign",
             "alarm_waterbox",

             "errsign_work1",
             "errsign_work2",
             "errsign_lose1",
             "errsign_lose2",
             "errsign_lose3",
             "errsign_lose4",
             "errsign_failure1",
             "errsign_failure2",
             "errsign_new",
             "alarmsign_new",
             "sumheat",
             "sumflow",

             "intemp",
             "outtemp",
             "valvepercent",
             "sumheat2",
             "sumflow2",
             "intemp2",
             "outtemp2",
             "num_heat1",
        };

        public Dictionary<string,string> Dictionary { get; set; }

        public GatherData()
        {
            Dictionary = new Dictionary<string, string>();
            foreach(var name in ParaNames)
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
