using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SmartHeatStationParaInfo
{
    class FileSaveSerice
    {
        const string ConfigPath = "C:\\ProgramData\\FlowMeterConfig";
        const string ConfigSaveFileName = "\\config.cfg";
        const string OptionsSaveFileName = "\\apopt.opt";
        const string FlowMeterParaSaveFilter = "参数保存文件（*.para）|*.para";

        public void SaveStationsData(List<Station> stations)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath +"\\stations.txt", FileMode.Create);
                StreamWriter w = new StreamWriter(fs);

                foreach (Station station in stations)
                {
                    w.Write(station.ToString());
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

        public void LoadStationsData(List<Station> stations)
        {
            string path = Application.StartupPath;
            string savePath = Application.StartupPath;
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + "\\stations.txt", FileMode.Open);
                StreamReader r = new StreamReader(fs);

                string strRead = r.ReadToEnd();
                string[] strStations = strRead.Split('&');
                for(int i = 0;i< strStations.Length - 1 ;++i)
                {
                    var strParas = strStations[i].Split('|');
                    stations[i].Paras = strParas;
                }

                //MessageBox.Show("保存成功！");
                r.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                return;
            }


        }

    }
}
