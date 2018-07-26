
using SQLite;

namespace SmartHeatStation.Sqlite.Models
{
    [Table("StationFixPara")]
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

    }
}
