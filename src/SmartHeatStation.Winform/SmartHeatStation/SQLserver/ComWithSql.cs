using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;
using 流量计检定上位机.SmartHeatStation.Models;

namespace SmartHeatStation.SQLserver
{
    public class ComWithSql
    {
        SqlCommand command;
        SqlConnection con;

        public string ServerName { get; set; } = ".";
        public string DatabaseName { get; set; } = ".";
        public string UidName { get; set; } = "sa";
        public string PwdName { get; set; } = "123";

        public bool IsConnect { get; set; }

        public ComWithSql()
        {
            con = new SqlConnection();
        }

        public bool OpenDatabase()
        {
            try
            {
                con.ConnectionString = $"server={ServerName};database={DatabaseName};uid={UidName};pwd={PwdName}";
                con.Open();
                IsConnect = true;
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool CloseDatabase()
        {
            try
            {
                con.Close();
                IsConnect = false;
                return true;
            }
            catch
            {
                return false;
            }

        }

        public string FindGatherData(List<GatherData> pGatherDatas)
        {
            try
            {
                command = new SqlCommand();
                command.Connection = con;
                //command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [dbo].[gather_currentdata]";
                var abc = command.ExecuteNonQuery();
                if (abc != -1)
                    return "";
                SqlDataReader dataReader = command.ExecuteReader();
                string str = "";

                pGatherDatas.Clear();
                while (dataReader.Read())
                {

                    var gatherData = new GatherData();
                    foreach (var name in GatherData.ParaNames)
                    {
                        string temp = dataReader[name].ToString();
                        gatherData.Dictionary[name] = temp;
                        str += temp + " ";
                    }
                    pGatherDatas.Add(gatherData);
                    str += "\r\n";
                }
                dataReader.Close();
                return str;
            }
            catch
            {
                return "Error";
            }


        }

        public string FindStationCode(List<StationCode> pStationCodes)
        {
            try
            {

                command = new SqlCommand();
                command.Connection = con;
                //command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [dbo].[code_stations]";
                var abc = command.ExecuteNonQuery();
                if (abc != -1)
                    return "";
                SqlDataReader dataReader = command.ExecuteReader();
                string str = "";

                pStationCodes.Clear();
                while (dataReader.Read())
                {
                    var stationCode = new StationCode();

                    foreach (var name in StationCode.ParaNames)
                    {
                        string temp = dataReader[name].ToString();
                        stationCode.Dictionary[name] = temp;
                        str += temp + " ";
                    }
                    pStationCodes.Add(stationCode);
                    str += "\r\n";
                }
                dataReader.Close();
                return str;
            }
            catch
            {
                return "Error";
            }

        }

        public string FindGatherErrors(List<GatherError> pGatherErrors)
        {
            try
            {
                command = new SqlCommand();
                command.Connection = con;
                //command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [dbo].[gather_currentdata_errors]";
                var abc = command.ExecuteNonQuery();
                if (abc != -1)
                    return "";
                SqlDataReader dataReader = command.ExecuteReader();
                string str = "";

                pGatherErrors.Clear();
                while (dataReader.Read())
                {

                    var gatherError = new GatherError();
                    foreach (var name in GatherError.ParaNames)
                    {
                        string temp = dataReader[name].ToString();
                        gatherError.Dictionary[name] = temp;
                        str += temp + " ";
                    }
                    pGatherErrors.Add(gatherError);
                    str += "\r\n";
                }
                dataReader.Close();
                return str;
            }
            catch
            {
                return "Error";
            }


        }

        public bool ChangeData()
        {
            try
            {
                command = new SqlCommand();
                command.Connection = con;
                //command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='False' where stationid ='4' ";
                var abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='False' where stationid ='8' ";
                abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='False' where stationid ='32' ";
                abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='False' where stationid ='43' ";
                abc = command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal bool RenewData()
        {
            try
            {
                command = new SqlCommand();
                command.Connection = con;
                //command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='True' where stationid ='4' ";
                var abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='True' where stationid ='8' ";
                abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='True' where stationid ='32' ";
                abc = command.ExecuteNonQuery();
                command.CommandText = "UPDATE [dbo].[gather_currentdata]  set errsign ='True' where stationid ='43' ";
                abc = command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
