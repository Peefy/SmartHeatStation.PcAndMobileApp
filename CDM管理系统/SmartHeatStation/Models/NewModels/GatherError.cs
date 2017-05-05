using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.SmartHeatStation.Models
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

    }
}
