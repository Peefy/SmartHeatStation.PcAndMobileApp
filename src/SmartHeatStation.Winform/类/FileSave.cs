using System;
using System.IO;
using System.Windows.Forms;

namespace 流量计检定上位机
{
    class FileSave
    {
        const string ConfigPath = "C:\\ProgramData\\FlowMeterConfig";
        const string ConfigSaveFileName = "\\config.cfg";
        const string OptionsSaveFileName = "\\apopt.opt";
        const string FlowMeterParaSaveFilter = "参数保存文件（*.para）|*.para";

        static float[] para = new float[10];
        // no
        public static bool ClosingSaveAppInfo(Demarcate pDemarcate,FlowMeterStandard pflowMeterStad,FlowMeterWork pflowMeterWork)
        {
            #region 存入配置文件
            try
            {
                if (Directory.Exists(ConfigPath) == false) Directory.CreateDirectory(ConfigPath);
                FileStream fs = new FileStream(ConfigPath + ConfigSaveFileName, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);
                #region 要存入的参数或者字符串
                w.Write(pDemarcate.SocketConnectIPstring);
                w.Write(pDemarcate.IsAutoMode);
                w.Write(pDemarcate.Count);
                w.Write(pDemarcate.Time);
                w.Write(pDemarcate.Interval);
                
                para = pflowMeterStad.Para;
                for (int i = 0; i < 10; ++i)
                    w.Write(para[i]);

                para = pflowMeterWork.Para;
                for (int i = 0; i < 10; ++i)
                    w.Write(para[i]);

                #endregion
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }
            #endregion

            return true;
        }
        // no
        public static bool LoadSaveAppInfo(Demarcate pDemarcate, FlowMeterStandard pflowMeterStad, FlowMeterWork pflowMeterWork)
        {
            #region 读取配置数据
            if (File.Exists(ConfigPath + ConfigSaveFileName))
            {
                try
                {
                    FileStream fs = new FileStream(ConfigPath + ConfigSaveFileName, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    #region 读取的数据或字符串

                     pDemarcate.SocketConnectIPstring = r.ReadString();
                    pDemarcate.IsAutoMode = r.ReadBoolean();
                    pDemarcate.Count = r.ReadInt32();
                    pDemarcate.Time = r.ReadInt32();
                    pDemarcate.Interval = r.ReadInt32();
                   

                    for (int i = 0; i < 10; ++i)
                        para[i] = r.ReadSingle();
                    pflowMeterStad.Para = para;

                    for (int i = 0; i < 10; ++i)
                        para[i] = r.ReadSingle();
                    pflowMeterWork.Para = para;

                    #endregion
                    r.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                      throw (ex);
                }

            }
            #endregion

            return true;
        }
        // no
        public void SavePara(FlowMeterStandard pflowMeterStad, FlowMeterWork pflowMeterWork, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Filter = FlowMeterParaSaveFilter;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fst = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件
                fst.Close();
                var savePath = saveFileDialog.FileName.ToString(); //获得文件路径           
                try
                {
                    FileStream fs = new FileStream(savePath, FileMode.Create);
                    BinaryWriter w = new BinaryWriter(fs);

                    para = pflowMeterStad.Para;
                    for (int i = 0; i < 10; ++i)
                        w.Write(para[i]);

                    para = pflowMeterWork.Para;
                    for (int i = 0; i < 10; ++i)
                        w.Write(para[i]);

                    w.Flush();
                    w.Close();
                    fs.Close();
                    MessageBox.Show("保存参数成功！");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }
        // no
        public bool LoadPara(FlowMeterStandard pflowMeterStad, FlowMeterWork pflowMeterWork, OpenFileDialog openFileDialog)
        {
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = FlowMeterParaSaveFilter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resultFile = openFileDialog.FileName;
                if (File.Exists(resultFile))
                {
                    try
                    {
                        FileStream fs = new FileStream(resultFile, FileMode.Open);
                        BinaryReader r = new BinaryReader(fs);

                        for (int i = 0; i < 10; ++i)
                            para[i] = r.ReadSingle();
                        pflowMeterStad.Para = para;

                        for (int i = 0; i < 10; ++i)
                            para[i] = r.ReadSingle();
                        pflowMeterWork.Para = para;

                        r.Close();
                        fs.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                }
                return false;
            }
            return false;
        }

        public void SaveDemarcateData(DemarcateMotion[] demarcateMotion)
        {
            string path = Application.StartupPath;
            string savePath = Directory.GetParent(path).FullName + "\\Log\\" + TimeHelper.GetYYMMDDTime();
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath +"\\Demarcate" + TimeHelper.GetHHMMSSTime() +".dma", FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);

                w.Write(DateTime.Now.ToString());
                foreach(DemarcateMotion dema in demarcateMotion)
                {
                    DemarcateMotionSave demaSave = new DemarcateMotionSave();
                    demaSave.Para = dema.Para;
                    w.Write(demaSave.FlowDema);
                    w.Write(demaSave.StanPulseCount);
                    w.Write(demaSave.StanFlowSum);
                    w.Write(demaSave.WorkPulseCount);
                    w.Write(demaSave.WorkFlowSum);
                    w.Write(demaSave.Error);
                    w.Write(demaSave.MeterFactor);
                }
                     
                MessageBox.Show("保存成功！");
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }


        }

    }
}
