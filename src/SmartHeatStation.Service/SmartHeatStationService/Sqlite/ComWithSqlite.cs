using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SQLite;
using SmartHeatStationService.Models;

namespace SmartHeatStationService.Sqlite
{
    public class ComWithSqlite
    {
        public string TableName { get; set; } = "StationFixPara";
        public string DatabaseName { get; set; } = "StationCode";
        SQLiteConnection conn;

        public ComWithSqlite()
        {
            conn = null;

            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/" + DatabaseName +".db";
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建  
            string sql = $"CREATE TABLE IF NOT EXISTS {TableName}({StationFixPara.CreateTableToString()});";//建表语句  
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表  
            //conn.Close();
        }

        public void InsertData()
        {
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            var data = new StationFixPara();
            cmdInsert.CommandText = $"INSERT INTO {TableName} VALUES({data.ValuesTableToString()})";//插入几条数据  
            cmdInsert.ExecuteNonQuery();
            data = new StationFixPara();
            cmdInsert.CommandText = $"INSERT INTO {TableName} VALUES({data.ValuesTableToString()})";
            cmdInsert.ExecuteNonQuery();
            data = new StationFixPara();
            cmdInsert.CommandText = $"INSERT INTO {TableName} VALUES({data.ValuesTableToString()})";
            cmdInsert.ExecuteNonQuery();
        }

        public void Close() => conn?.Close();

        public void InsertData(List<StationCode> stationCodes)
        {
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            int i = 0;
            foreach(var stationCode in stationCodes)
            {
                var data = new StationFixPara()
                {
                    ID = i,
                    Name = stationCode.Dictionary["station"],
                    ActArea = stationCode.Dictionary["actarea"],
                    Addr = stationCode.Dictionary["addr"],
                    DisplaySort = stationCode.Dictionary["dispsort"],
                    FC1_Visible = stationCode.Dictionary["fc1visible"],
                    FC2_Visible = stationCode.Dictionary["fc2visible"],
                    FC3_Visible = stationCode.Dictionary["fc3visible"],
                    FC4_Visible = stationCode.Dictionary["fc4visible"],
                    FC5_Visible = stationCode.Dictionary["fc5visible"],
                    FC6_Visible = stationCode.Dictionary["fc6visible"],
                    FC7_Visible = stationCode.Dictionary["fc7visible"],
                    FC8_Visible = stationCode.Dictionary["fc8visible"],
                    FC9_Visible = stationCode.Dictionary["fc9visible"],
                    FC10_Visible = stationCode.Dictionary["fc10visible"],
                    RegieterArea = stationCode.Dictionary["registearea"],
                    Flow1_Visible = stationCode.Dictionary["flow1visible"],
                    Flow2_Visible = stationCode.Dictionary["flow2visible"],
                    Flow3_Visible = stationCode.Dictionary["flow3visible"],
                    Flow4_Visible = stationCode.Dictionary["flow4visible"],
                    Ip = stationCode.Dictionary["ip"],
                    Port = stationCode.Dictionary["port"],
                    IsUsed = stationCode.Dictionary["used"],
                    LP1_Visible = stationCode.Dictionary["lp1visible"],
                    LP2_Visible = stationCode.Dictionary["lp2visible"],
                    LP3_Visible = stationCode.Dictionary["lp3visible"],
                    LP4_Visible = stationCode.Dictionary["lp4visible"],

                    LT1_Visible = stationCode.Dictionary["lt1visible"],
                    LT2_Visible = stationCode.Dictionary["lt2visible"],
                    LT3_Visible = stationCode.Dictionary["lt3visible"],
                    LT4_Visible = stationCode.Dictionary["lt4visible"],

                    SP1_Visible = stationCode.Dictionary["sp1visible"],
                    SP2_Visible = stationCode.Dictionary["sp2visible"],
                    SP3_Visible = stationCode.Dictionary["sp3visible"],
                    SP4_Visible = stationCode.Dictionary["sp4visible"],

                    ST1_Visible = stationCode.Dictionary["lt1visible"],
                    ST2_Visible = stationCode.Dictionary["lt2visible"],
                    ST3_Visible = stationCode.Dictionary["lt3visible"],
                    ST4_Visible = stationCode.Dictionary["lt4visible"],

                    WaterboxDown = stationCode.Dictionary["waterbox_down"],
                    WaterboxHeight = stationCode.Dictionary["waterboxheight"],
                    WaterboxStop = stationCode.Dictionary["waterbox_stop"],
                    WaterboxSupply = stationCode.Dictionary["waterbox_supply"],
                    WaterboxUp = stationCode.Dictionary["waterbox_up"],
                    Waterbox_VisiBle = stationCode.Dictionary["waterboxvisible"],
                };
                ++i;
                cmdInsert.CommandText = $"INSERT INTO {TableName} VALUES({data.ValuesTableToString()})";//插入几条数据  
                cmdInsert.ExecuteNonQuery();
            }
        }
    }
}
