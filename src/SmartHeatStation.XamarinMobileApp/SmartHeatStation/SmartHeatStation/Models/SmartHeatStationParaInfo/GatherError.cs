using System.Collections.Generic;

namespace SmartHeatStation.Models.ParaInfo
{
    public class GatherError
    {
        public static string[] ParaNames =
        {
             "error_sign1",
             "error_sign2",
             "error_sign3",
             "error_sign4",
             "error_sign5",
             "error_sign6",
             "error_sign7",
             "error_sign8",
             "error_sign9",
             "error_sign10",
             "error_sign11",
             "error_sign12",
             "error_sign13",
             "error_sign14",
             "error_sign15",
             "error_sign16",
             "error_sign17",
             "error_sign18",
             "error_sign19",
             "error_sign20",
             "error_sign21",
             "error_sign22",
             "error_sign23",
             "error_sign24",
             "error_sign25",
             "error_sign26",
             "error_sign27",
             "error_sign28",
             "error_sign29",
             "error_sign30",
             "error_sign31",
             "error_sign32",
             "error_sign33",
             "error_sign34",
             "error_sign35",
             "error_sign36",
             "error_sign37",
             "error_sign38",
             "error_sign39",
             "error_sign40",
             "error_sign41",
             "error_sign42",
             "error_sign43",
             "error_sign44",
             "error_sign45",
             "error_sign46",
             "error_sign47",
             "error_sign48",
             "error_sign49",
             "error_sign50",
             "error_sign51",
             "error_sign52",
             "error_sign53",
             "error_sign54",
             "error_sign55",
             "error_sign56",
             "error_sign57",
             "error_sign58",
             "error_sign59",
             "error_sign60",
             "error_sign61",
             "error_sign62",
             "error_sign63",
             "error_sign64",

             "error_linksign",
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

        public GatherError()
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


        string[] ErrorCommNames = 
        {
            "一次供压通讯故障;", //17
            "一次回压通讯故障;", //18
            "一次供温通讯故障;", //19
            "一次回温通讯故障;", //20

            "二次低区供压通讯故障;",//21
            "二次低区回压通讯故障;",//22
            "二次低区供温通讯故障;",//23
            "二次低区回温通讯故障;",//24

            "二次中区供压通讯故障;",//25
            "二次中区回压通讯故障;",//26
            "二次中区供温通讯故障;",//27
            "二次中区回温通讯故障;",//28

            "二次高区供压通讯故障;",//29
            "二次高区回压通讯故障;",//30
            "二次高区供温通讯故障;",//31
            "二次高区回温通讯故障;",//32

            "备用1通讯故障;",//33
            "备用2通讯故障;",//34
            "备用3通讯故障;",//35
            "备用4通讯故障;",//36

            "变频1通讯故障;",//38
            "变频2通讯故障;",//39
            "变频3通讯故障;",//40
            "变频4通讯故障;",//41
            "变频5通讯故障;",//42
            "变频6通讯故障;",//43
            "变频7通讯故障;",//44
            "变频8通讯故障;",//45
            "变频9通讯故障;",//46
            "变频10通讯故障;",//47


        };

        string[] ErrorDeviceNames = 
        {

            "变频1设备故障;",//49
            "变频2设备故障;",//50
            "变频3设备故障;",//51
            "变频4设备故障;",//52
            "变频5设备故障;",//53
            "变频6设备故障;",//54
            "变频7设备故障;",//55
            "变频8设备故障;",//56
            "变频9设备故障;",//57
            "变频10设备故障;",//58

            "现场停电故障;",//59
            "水箱漫水故障;",//60

        };

        public string ErrorReason
        {
            get
            {
                string str = "";
                if(Dictionary["error_linksign"] == "True")
                {
                    str += "连接故障;";
                }
                if(Dictionary["error_sign1"] == "False")
                {
                    str += "换热站没有开始工作;";
                }

                for(int i = 0;i < ErrorCommNames.Length;++i)
                {
                    int errorIndex = i + 17;
                    if(Dictionary[$"error_sign{errorIndex}"] == "True")
                    {
                        str += ErrorCommNames[i];
                    }
                }

                for(int i = 0;i < ErrorDeviceNames.Length;++i)
                {
                    int errorIndex = i + 49;
                    if(Dictionary[$"error_sign{errorIndex}"] == "True")
                    {
                        str += ErrorDeviceNames[i];
                    }
                }
                return str;
            }
        }

    }
}
