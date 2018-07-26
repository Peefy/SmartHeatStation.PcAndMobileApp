
using System;

namespace SmartHeatStationService.Sqlite
{

    public class StationFixPara : BaseSqliteModel
    {
        public string IsUsed { get; set; } = "True";
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Addr { get; set; }
        public string DisplaySort { get; set; }

        public string Waterbox_VisiBle { get; set; } = "True";
        public string WaterboxHeight { get; set; }
        public string WaterboxSupply { get; set; }
        public string WaterboxStop { get; set; }
        public string WaterboxUp { get; set; }
        public string WaterboxDown { get; set; }

        public string SP1_Visible { get; set; } = "True";
        public string LP1_Visible { get; set; } = "True";
        public string ST1_Visible { get; set; } = "True";
        public string LT1_Visible { get; set; } = "True";
        public string Flow1_Visible { get; set; } = "True";

        public string SP2_Visible { get; set; } = "True";
        public string LP2_Visible { get; set; } = "True";
        public string ST2_Visible { get; set; } = "True";
        public string LT2_Visible { get; set; } = "True";
        public string Flow2_Visible { get; set; } = "True";

        public string SP3_Visible { get; set; } = "True";
        public string LP3_Visible { get; set; } = "True";
        public string ST3_Visible { get; set; } = "True";
        public string LT3_Visible { get; set; } = "True";
        public string Flow3_Visible { get; set; } = "True";

        public string SP4_Visible { get; set; } = "True";
        public string LP4_Visible { get; set; } = "True";
        public string ST4_Visible { get; set; } = "True";
        public string LT4_Visible { get; set; } = "True";
        public string Flow4_Visible { get; set; } = "True";

        public string FC1_Visible { get; set; } = "True";
        public string FC2_Visible { get; set; } = "True";
        public string FC3_Visible { get; set; } = "True";
        public string FC4_Visible { get; set; } = "True";
        public string FC5_Visible { get; set; } = "True";
        public string FC6_Visible { get; set; } = "True";
        public string FC7_Visible { get; set; } = "True";
        public string FC8_Visible { get; set; } = "True";
        public string FC9_Visible { get; set; } = "True";
        public string FC10_Visible { get; set; } = "True";

        public string RegieterArea { get; set; } = "sdfsfsf";
        public string ActArea { get; set; } = "adsad";

        public static string CreateTableToString()
        {
            return nameof(ID) + " integer, " +
                nameof(Name) + " varchar(30), " +
                nameof(IsUsed) + " varchar(10), " +
                nameof(Ip) + " varchar(20), " +
                nameof(Port) + " varchar(10), " +
                nameof(Addr) + " varchar(30), " +
                nameof(DisplaySort) + " varchar(10), " +

                nameof(Waterbox_VisiBle) + " varchar(10), " +
                nameof(WaterboxHeight) + " varchar(10), " +
                nameof(WaterboxSupply) + " varchar(10), " +
                nameof(WaterboxStop) + " varchar(10), " +
                nameof(WaterboxUp) + " varchar(10), " +
                nameof(WaterboxDown) + " varchar(10), " +

                nameof(SP1_Visible) + " varchar(10), " +
                nameof(LP1_Visible) + " varchar(10), " +
                nameof(ST1_Visible) + " varchar(10), " +
                nameof(LT1_Visible) + " varchar(10), " +
                nameof(Flow1_Visible) + " varchar(10), " +

                nameof(SP2_Visible) + " varchar(10), " +
                nameof(LP2_Visible) + " varchar(10), " +
                nameof(ST2_Visible) + " varchar(10), " +
                nameof(LT2_Visible) + " varchar(10), " +
                nameof(Flow2_Visible) + " varchar(10), " +

                nameof(SP3_Visible) + " varchar(10), " +
                nameof(LP3_Visible) + " varchar(10), " +
                nameof(ST3_Visible) + " varchar(10), " +
                nameof(LT3_Visible) + " varchar(10), " +
                nameof(Flow3_Visible) + " varchar(10), " +

                nameof(SP4_Visible) + " varchar(10), " +
                nameof(LP4_Visible) + " varchar(10), " +
                nameof(ST4_Visible) + " varchar(10), " +
                nameof(LT4_Visible) + " varchar(10), " +
                nameof(Flow4_Visible) + " varchar(10), " +

                nameof(FC1_Visible) + " varchar(10), " +
                nameof(FC2_Visible) + " varchar(10), " +
                nameof(FC3_Visible) + " varchar(10), " +
                nameof(FC4_Visible) + " varchar(10), " +
                nameof(FC5_Visible) + " varchar(10), " +
                nameof(FC6_Visible) + " varchar(10), " +
                nameof(FC7_Visible) + " varchar(10), " +
                nameof(FC8_Visible) + " varchar(10), " +
                nameof(FC9_Visible) + " varchar(10), " +
                nameof(FC10_Visible) + " varchar(10), " +

                nameof(RegieterArea) + " varchar(20), " +
                nameof(ActArea) + " varchar(20)"; 

        }

        public string ValuesTableToString()
        {
            return ID.ToString() + ", " +
                $"'{Name}', " +
                $"'{IsUsed}', " +
                $"'{Ip}', " +
                $"'{Port}', " +
                $"'{Addr}', " +
                $"'{DisplaySort}', " +

                $"'{Waterbox_VisiBle}', " +
                $"'{WaterboxHeight}', " +
                $"'{WaterboxSupply}', " +
                $"'{WaterboxStop}', " +
                $"'{WaterboxUp}', " +
                $"'{WaterboxDown}', " +

                $"'{SP1_Visible}', " +
                $"'{LP1_Visible}', " +
                $"'{ST1_Visible}', " +
                $"'{LT1_Visible}', " +
                $"'{Flow1_Visible}', " +

                $"'{SP2_Visible}', " +
                $"'{LP2_Visible}', " +
                $"'{ST2_Visible}', " +
                $"'{LT2_Visible}', " +
                $"'{Flow2_Visible}', " +

                $"'{SP3_Visible}', " +
                $"'{LP3_Visible}', " +
                $"'{ST3_Visible}', " +
                $"'{LT3_Visible}', " +
                $"'{Flow3_Visible}', " +

                $"'{SP4_Visible}', " +
                $"'{LP4_Visible}', " +
                $"'{ST4_Visible}', " +
                $"'{LT4_Visible}', " +
                $"'{Flow4_Visible}', " +

                $"'{FC1_Visible}', " +
                $"'{FC2_Visible}', " +
                $"'{FC3_Visible}', " +
                $"'{FC4_Visible}', " +
                $"'{FC5_Visible}', " +
                $"'{FC6_Visible}', " +
                $"'{FC7_Visible}', " +
                $"'{FC8_Visible}', " +
                $"'{FC9_Visible}', " +
                $"'{FC10_Visible}', " +

                $"'{RegieterArea}', " +
                $"'{ActArea}'"; 
        }

    }
}
