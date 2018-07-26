using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流量计检定上位机.SmartHeatStation.Models
{
    public class GetParaValue
    {
        Dictionary<string, string> mStationCode;
        Dictionary<string, string> mGatherData;
        Dictionary<string, string> mGatherError;

        public GetParaValue(Dictionary<string, string> pStationCode, Dictionary<string, string> pGatherData)
        {
            mStationCode = pStationCode;
            mGatherData = pGatherData;
        }

        public GetParaValue(Dictionary<string, string> pStationCode,
            Dictionary<string, string> pGatherData,
            Dictionary<string, string> pGatherError)
        {
            mStationCode = pStationCode;
            mGatherData = pGatherData;
            mGatherError = pGatherError;
        }

        public bool Alarm一次网
        {
            get
            {
                return mGatherData["alarm_sp1sign"] == "Ture" ||
                    mGatherData["alarm_lp1sign"] == "Ture" ||
                    mGatherData["alarm_st1sign"] == "Ture" ||
                    mGatherData["alarm_lt1sign"] == "Ture" ||
                    mGatherData["alarm_flow1sign"] == "Ture";

            }
        }

        public bool Alarm二次低区
        {
            get
            {
                return mGatherData["alarm_sp2sign"] == "True" ||
                    mGatherData["alarm_lp2sign"] == "True" ||
                    mGatherData["alarm_st2sign"] == "True" ||
                    mGatherData["alarm_lt2sign"] == "True" ||
                    mGatherData["alarm_flow2sign"] == "True";

            }
        }

        public bool Alarm二次中区
        {
            get
            {
                return mGatherData["alarm_sp3sign"] == "True" ||
                    mGatherData["alarm_lp3sign"] == "True" ||
                    mGatherData["alarm_st3sign"] == "True" ||
                    mGatherData["alarm_lt3sign"] == "True" ||
                    mGatherData["alarm_flow3sign"] == "True";

            }
        }

        public bool Alarm二次高区
        {
            get
            {
                return mGatherData["alarm_sp4sign"] == "True" ||
                    mGatherData["alarm_lp4sign"] == "True" ||
                    mGatherData["alarm_st4sign"] == "True" ||
                    mGatherData["alarm_lt4sign"] == "True" ||
                    mGatherData["alarm_flow4sign"] == "True";

            }
        }

        public bool Alarm水箱
        {
            get
            {
                return mGatherData["alarm_waterbox"] == "True";
            }
        }

        public bool GeAlarm变频控制Para(int i)
        {
            return mGatherData[$"alarm_fc{i}sign"] == "True";
        }

        public string Num一次网
        {
            get
            {
                //string str = "";
                return //mStationCode["alarm_sp1choose"] + "|" +
                       //mStationCode["alarm_sp1sign"] + "|" +
                    mStationCode["alarm_sp1up"] + "|" +
                    mStationCode["alarm_sp1down"] + "|" +
                    //mStationCode["alarm_lp1choose"] + "|" +
                    //mStationCode["alarm_lp1sign"] + "|" +
                    mStationCode["alarm_lp1up"] + "|" +
                    mStationCode["alarm_lp1down"] + "|" +
                    //mStationCode["alarm_st1choose"] + "|" +
                    //mStationCode["alarm_st1sign"] + "|" +
                    mStationCode["alarm_st1up"] + "|" +
                    mStationCode["alarm_st1down"] + "|" +
                    //mStationCode["alarm_lt1choose"] + "|" +
                    //mStationCode["alarm_lt1sign"] + "|" +
                    mStationCode["alarm_lt1up"] + "|" +
                    mStationCode["alarm_lt1down"] + "|" +
                    //mStationCode["alarm_flow1choose"] + "|" +
                    //mStationCode["alarm_flow1sign"] + "|" +
                    mStationCode["alarm_flow1up"] + "|" +
                    mStationCode["alarm_flow1down"] + "|" +

                    mGatherData["num_sp1"] + "|" +
                    mGatherData["num_lp1"] + "|" +
                    mGatherData["num_st1"] + "|" +
                    mGatherData["num_lt1"] + "|" +
                    mGatherData["num_flow1"] + "|";

                //mGatherData["alarm_sp1sign"] + "|" +
                //mGatherData["alarm_lp1sign"] + "|" +
                //mGatherData["alarm_st1sign"] + "|" +
                //mGatherData["alarm_lt1sign"] + "|" +
                //mGatherData["alarm_flow1sign"] + "|";


            }
        }

        public string Num二次低区
        {
            get
            {
                //string str = "";
                return //mStationCode["alarm_sp2choose"] + "|" +
                       //mStationCode["alarm_sp2sign"] + "|" +
                        mStationCode["alarm_sp2up"] + "|" +
                         mStationCode["alarm_sp2down"] + "|" +
                         //mStationCode["alarm_lp2choose"] + "|" +
                         //mStationCode["alarm_lp2sign"] + "|" +
                         mStationCode["alarm_lp2up"] + "|" +
                         mStationCode["alarm_lp2down"] + "|" +
                         //mStationCode["alarm_st2choose"] + "|" +
                         //mStationCode["alarm_st2sign"] + "|" +
                         mStationCode["alarm_st2up"] + "|" +
                         mStationCode["alarm_st2down"] + "|" +
                         //mStationCode["alarm_lt2choose"] + "|" +
                         //mStationCode["alarm_lt2sign"] + "|" +
                         mStationCode["alarm_lt2up"] + "|" +
                         mStationCode["alarm_lt2down"] + "|" +
                         //mStationCode["alarm_flow2choose"] + "|" +
                         //mStationCode["alarm_flow2sign"] + "|" +
                         mStationCode["alarm_flow2up"] + "|" +
                         mStationCode["alarm_flow2down"] + "|" +

                        mGatherData["num_sp2"] + "|" +
                    mGatherData["num_lp2"] + "|" +
                    mGatherData["num_st2"] + "|" +
                    mGatherData["num_lt2"] + "|" +
                    mGatherData["num_flow2"] + "|";

                //mGatherData["alarm_sp2sign"] + "|" +
                //mGatherData["alarm_lp2sign"] + "|" +
                //mGatherData["alarm_st2sign"] + "|" +
                //mGatherData["alarm_lt2sign"] + "|" +
                //mGatherData["alarm_flow2sign"] + "|";
            }
        }

        public string Num二次中区
        {
            get
            {
                //string str = "";
                return //mStationCode["alarm_sp3choose"] + "|" +
                       //mStationCode["alarm_sp3sign"] + "|" +
             mStationCode["alarm_sp3up"] + "|" +
             mStationCode["alarm_sp3down"] + "|" +
             //mStationCode["alarm_lp3choose"] + "|" +
             //mStationCode["alarm_lp3sign"] + "|" +
             mStationCode["alarm_lp3up"] + "|" +
             mStationCode["alarm_lp3down"] + "|" +
             //mStationCode["alarm_st3choose"] + "|" +
             //mStationCode["alarm_st3sign"] + "|" +
             mStationCode["alarm_st3up"] + "|" +
             mStationCode["alarm_st3down"] + "|" +
             //mStationCode["alarm_lt3choose"] + "|" +
             //mStationCode["alarm_lt3sign"] + "|" +
             mStationCode["alarm_lt3up"] + "|" +
             mStationCode["alarm_lt3down"] + "|" +
             //mStationCode["alarm_flow3choose"] + "|" +
             //mStationCode["alarm_flow3sign"] + "|" +
             mStationCode["alarm_flow3up"] + "|" +
             mStationCode["alarm_flow3down"] + "|" +

                    mGatherData["num_sp3"] + "|" +
                    mGatherData["num_lp3"] + "|" +
                    mGatherData["num_st3"] + "|" +
                    mGatherData["num_lt3"] + "|" +
                    mGatherData["num_flow3"] + "|";

                //mGatherData["alarm_sp3sign"] + "|" +
                //mGatherData["alarm_lp3sign"] + "|" +
                //mGatherData["alarm_st3sign"] + "|" +
                //mGatherData["alarm_lt3sign"] + "|" +
                //mGatherData["alarm_flow3sign"] + "|";
            }
        }

        public string Num二次高区
        {
            get
            {
                //string str = "";
                return //mStationCode["alarm_sp4choose"] + "|" +
                       //mStationCode["alarm_sp4sign"] + "|" +
                    mStationCode["alarm_sp4up"] + "|" +
                    mStationCode["alarm_sp4down"] + "|" +
                    //mStationCode["alarm_lp4choose"] + "|" +
                    //mStationCode["alarm_lp4sign"] + "|" +
                    mStationCode["alarm_lp4up"] + "|" +
                    mStationCode["alarm_lp4down"] + "|" +
                    //mStationCode["alarm_st4choose"] + "|" +
                    //mStationCode["alarm_st4sign"] + "|" +
                    mStationCode["alarm_st4up"] + "|" +
                    mStationCode["alarm_st4down"] + "|" +
                    //mStationCode["alarm_lt4choose"] + "|" +
                    //mStationCode["alarm_lt4sign"] + "|" +
                    mStationCode["alarm_lt4up"] + "|" +
                    mStationCode["alarm_lt4down"] + "|" +
                    //mStationCode["alarm_flow4choose"] + "|" +
                    //mStationCode["alarm_flow4sign"] + "|" +
                    mStationCode["alarm_flow4up"] + "|" +
                    mStationCode["alarm_flow4down"] + "|" +

                    mGatherData["num_sp4"] + "|" +
                    mGatherData["num_lp4"] + "|" +
                    mGatherData["num_st4"] + "|" +
                    mGatherData["num_lt4"] + "|" +
                    mGatherData["num_flow4"] + "|";

                //mGatherData["alarm_sp4sign"] + "|" +
                //mGatherData["alarm_lp4sign"] + "|" +
                //mGatherData["alarm_st4sign"] + "|" +
                //mGatherData["alarm_lt4sign"] + "|" +
                //mGatherData["alarm_flow4sign"] + "|";
            }
        }

        public string Num水箱
        {
            get
            {
                return mStationCode["waterboxheight"] + " |" +
                       mStationCode["waterbox_supply"] + "|" +
                       mStationCode["waterbox_stop"] + "|" +
                       mStationCode["waterbox_up"] + "|" +
                       mStationCode["waterbox_down"] + "|" +
                       mGatherData["alarm_waterbox"] + "|" +
                       mGatherData["num_waterboxheight"] + "|" +
                       mGatherData["num_waterposition"] + "|";

            }
        }

        public string Num补水压力设备
        {
            get
            {
                return mGatherData["num_swp"] + "|" +
                    mGatherData["num_elec"] + "|" +
                    mGatherData["num_watermeter"] + "|" +
                     mGatherData["alarm_floorwater"] + "|" +
                    mGatherData["num_ot"] + "|";
            }
        }

        public string Num热量流量表1
        {
            get
            {
                return mGatherData["sumheat"] + "|" +
                    mGatherData["sumflow"] + "|";
            }
        }

        public string Num热量流量表2
        {
            get
            {
                return mGatherData["sumheat2"] + "|" +
                    mGatherData["sumflow2"] + "|";
            }
        }

        public string Num入出口温度1
        {
            get
            {
                return mGatherData["intemp"] + "|" +
                    mGatherData["outtemp"] + "|";
            }
        }

        public string Num入出口温度2
        {
            get
            {
                return mGatherData["intemp2"] + "|" +
                    mGatherData["outtemp2"] + "|";
            }
        }

        public string Num总调节阀
        {
            get
            {
                return mStationCode["valvemax"] + "|" +
                    mStationCode["valvemin"] + "|" +
                    mGatherData["valvepercent"] + "|";
            }
        }

        public string Num错误标志
        {
            get
            {
                return mGatherData["errsign_work1"] + "|" +
                    mGatherData["errsign_work2"] + "|" +
                    mGatherData["errsign_lose1"] + "|" +
                     mGatherData["errsign_lose2"] + "|" +
                     mGatherData["errsign_lose3"] + "|" +
                     mGatherData["errsign_lose4"] + "|" +
                     mGatherData["errsign_failure1"] + "|" +
                     mGatherData["errsign_failure2"] + "|" +
                    mGatherData["num_ot"] + "|";
            }
        }

        public string GetNum变频控制Para(int i)
        {
            if (i <= 6)
            {
                return
                    mGatherData[$"num_fc{i}_f"] + "|" +
                            mGatherData[$"num_fc{i}_s"] + "|" +
                            mGatherData[$"num_fc{i}_c"] + "|";
                //mGatherData[$"alarm_fc{i}sign"] + " |"

                //mStationCode[$"alarm_fc{i}choose"] + "|" +
                //mStationCode[$"alarm_fc{i}sign"] + "|" +
                //mStationCode[$"alarm_fc{i}up"] + "|" +
                //mStationCode[$"alarm_fc{i}down"] + "|";

            }
            else
            {
                return mGatherData[$"num_fc{i}_f"] + "|";
                //mGatherData[$"alarm_fc{i}sign"] + " |";

                //mStationCode[$"alarm_fc{i}choose"] + "|" +
                //mStationCode[$"alarm_fc{i}sign"] + "|" +
                //mStationCode[$"alarm_fc{i}up"] + "|" +
                //mStationCode[$"alarm_fc{i}down"] + "|";

            }
        }

        public string StationName
        {
            get
            {
                return mStationCode["station"].Split(')')[1];
            }
        }

        public bool ErrorSign
        {
            get
            {
                return mGatherData["errsign"] == "True";
            }
        }

        public bool AlarmSign
        {
            get
            {
                return mGatherData["alarmsign"] == "True";
            }
        }

    }
}
