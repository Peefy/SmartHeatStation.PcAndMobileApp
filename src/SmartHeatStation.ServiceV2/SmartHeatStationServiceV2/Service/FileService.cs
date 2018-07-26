using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

using SmartHeatStationServiceV2.Models;
using SmartHeatStationServiceV2.SqlServer;

namespace SmartHeatStationServiceV2.Service
{
    public class FileService
    {
        public static void SaveStationsData(
            List<GatherData> gatherDatas,
            List<StationCode> stationCodes,
            List<GatherError> gatherErrors)
        {
            string savePath = Application.StartupPath;
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + "\\stations.txt", FileMode.Create);
                StreamWriter w = new StreamWriter(fs);

                foreach (var gatherData in gatherDatas)
                {
                    w.Write(gatherData.ToString());
                    w.Write("&");
                }

                w.Write("@");

                foreach (var stationCode in stationCodes)
                {
                    w.Write(stationCode.ToString());
                    w.Write("&");
                }

                w.Write("@");

                foreach (var gatherError in gatherErrors)
                {
                    w.Write(gatherError.ToString());
                    w.Write("&");
                }

                //MessageBox.Show("保存成功！");
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }
        }

        public static void SaveStationsData(string gatherDatas, string stationCodes)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + "\\stations.txt", FileMode.Create);
                StreamWriter w = new StreamWriter(fs);

                w.Write(gatherDatas);
                w.Write(stationCodes);

                //MessageBox.Show("保存成功！");
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }
        }

        public static void SaveUserConfig(ComWithSql pComWithSql)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            //try
            //{
            if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
            FileStream fs = new FileStream(savePath + "\\user.uni", FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);

            w.Write(pComWithSql.IsConnect);
            w.Write(pComWithSql.ServerName);
            w.Write(pComWithSql.DatabaseName);
            w.Write(pComWithSql.UidName);
            w.Write(pComWithSql.PwdName);

            w.Flush();
            w.Close();
            fs.Close();
            //}
            //catch (Exception es)
            //{
            //    throw (es);
            //}
        }

        public static void ReadUserConfig(ComWithSql pComWithSql)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + "\\user.uni", FileMode.Open);
                using (BinaryReader r = new BinaryReader(fs))
                {
                    pComWithSql.IsConnect = r.ReadBoolean();
                    pComWithSql.ServerName = r.ReadString();
                    pComWithSql.DatabaseName = r.ReadString();
                    pComWithSql.UidName = r.ReadString();
                    pComWithSql.PwdName = r.ReadString();
                }
                fs.Close();
            }
            catch (Exception es)
            {

            }
        }

        public static void SaveApplicationConfig(bool result)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            //try
            //{
            if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
            FileStream fs = new FileStream(savePath + "\\app.cfg", FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);

            w.Write(result);

            w.Flush();
            w.Close();
            fs.Close();
            //}
            //catch (Exception es)
            //{
            //    throw (es);
            //}
        }

        public static bool ReadApplicationConfig()
        {
            string savePath = Application.StartupPath;
            try
            {
                bool result;
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + "\\app.cfg", FileMode.Open);
                using (BinaryReader r = new BinaryReader(fs))
                {
                    result = r.ReadBoolean();

                }
                fs.Close();
                return result;
            }
            catch
            {
                return true;
            }
        }

    }
}
