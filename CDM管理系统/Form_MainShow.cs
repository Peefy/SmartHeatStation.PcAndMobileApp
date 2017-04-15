using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;
using Modbus;
using System.Net;
using SocketCom;
using Modbus.Device;
using System.IO.Ports;

using SmartHeatStationParaInfo;
using CCWin.SkinControl;

namespace 流量计检定上位机
{
    public partial class Form_MainShow : CCWin.CCSkinMain
    {
        #region 变量

        public static Form_Main formMain;

        Size FormSetParaSize = new Size(715, 620);
        Size FormNomalSize = new Size(490, 620);
        Size FormAboutSize = new Size(490, 710);

        CDM.ZedGraghUtils zedGraphUtils;
        CDM.ChartParameters paras = new CDM.ChartParameters();
        SerialPort serialPort = new SerialPort(); //create a new SerialPort object with default settings.
        ModbusSerialMaster master;

        public static List<Station> Stations;
        List<CCWin.SkinControl.SkinLabel> LabelStations;

        Thread UpLoadThread;

        SmartHeatStation.SQLserver.ComWithSql ComWithSqlServer;
        #endregion
        #region 主窗体初始化
        public Form_MainShow(Form_Main formmain)
        {
            formMain = formmain;
            InitializeComponent();
        }

        public void Init()
        {
            #region Init
            #region FormInit
            this.WindowState = FormWindowState.Maximized;
            #endregion
            #region FileInit
            //FileSave.LoadSaveAppInfo(demarcate, flowMeterStandard, flowMeterWork);
            #endregion

            #region 更新文件的数据到UI
            #endregion
            Thread.Sleep(100);

            Stations = new List<Station>
            {
                new Station() {Name = "阿尔滨站", 一网 = new Area() {供水压力 = new Para() {Value = "2" } } },
                new Station() {Name = "金渤海景站",水箱 = new WaterBox() {真实液位高度 = "10" } },
                new Station() {Name = "南山站" },
                new Station() {Name = "金山站" },
                new Station() {Name = "政府站" },

                new Station() {Name = "龙王站" },
                new Station() {Name = "自来水站" },
                new Station() {Name = "南棉站" },
                new Station() {Name = "盐场站" },
                new Station() {Name = "金海国际" },

                new Station() {Name = "北京郡站" },
                new Station() {Name = "光明西站",水箱进水阀 = new WaterVar() { 故障信号 = "1"} },
                new Station() {Name = "金海国际站" },
                new Station() {Name = "金连领地站" },
                new Station() {Name = "金山名苑站" },

                new Station() {Name = "欧美亚站" },
                new Station() {Name = "铁路站" },
                new Station() {Name = "五一站" },
                new Station() {Name = "于家洼站" },
                new Station() {Name = "环保站" },

            };

            LabelStations = new List<CCWin.SkinControl.SkinLabel>
            {
                labelStation0,
                labelStation1,
                labelStation2,
                labelStation3,
                labelStation4,
                labelStation5,
                labelStation6,
                labelStation7,
                labelStation8,
                labelStation9,
                labelStation10,
                labelStation11,
                labelStation12,
                labelStation13,
                labelStation14,
                labelStation15,
                labelStation16,
                labelStation17,
                labelStation18,
                labelStation19,
            };

            new FileSaveSerice().LoadStationsData(Stations);

            timer1_Tick(null, null);

            Thread.Sleep(100);
            UpLoadThread = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    new FileSaveSerice().SaveStationsData(Stations);
                    Thread.Sleep(1000);
                    new QiniuYun.UpLoad().uploadStreamTest();
                    Thread.Sleep(8000);
                }

            }));
            UpLoadThread.Start();
            timer1.Enabled = true;
            #endregion
            ComWithSqlServer = new SmartHeatStation.SQLserver.ComWithSql();
        }
        #endregion
        #region MenuView
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        #endregion

        #region FormEvent

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            MainTabControl.Width = Width - 10;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            labelVersion.Text = AppInfo.GetVersionInfo();
            GenerateSever();


        }

        public void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (UpLoadThread != null)
            {
                UpLoadThread.Abort();
                UpLoadThread = null;
            }

            if (master != null)
            {
                master.Dispose();
                master = null;
            }

            //FileSave.ClosingSaveAppInfo(demarcate, flowMeterStandard, flowMeterWork);

        }


        #endregion
        #region ReportAndExcel

        public void MenuItemGenerateReport_Click(object sender, EventArgs e)
        {

        }

        public void MenuItemGenerateExcel_Click(object sender, EventArgs e)
        {

            if(CDM.MiDuData.List.Count == 0)
            {
                MessageBox.Show("没有数据将不予生成");
                return;
            }
            try
            {
                new CDM.ExportExcel().Export(saveFileDialog);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region Print

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = new System.Drawing.Printing.PrintDocument();
            printDialog.ShowDialog();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printToolStripMenuItem_Click(sender, e);
        }

        #endregion
        #region About

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Size.Height < FormAboutSize.Height || this.Size.Width < FormAboutSize.Width)
                this.Size = FormAboutSize;
            labelVersion.Text = AppInfo.GetVersionInfo();
            //groupAbout.Visible = true;
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            //groupAbout.Visible = false;
        }


        #endregion        
        #region ParaSet

        public void SetFlowMeterStad_Click(object sender, EventArgs e)
        {
            
        }

        public void SetFlowMeterWork_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnFlowMeterParaCancel_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        #region ParaSave

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void OpenFile(object sender, EventArgs e)
        {
       
        }



        #endregion
        #region RecievaedTextBox

        private void textRecieved_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string txt = " Received:" + "\r\n" + "";
                //textRecieved.Text = txt;
            }
        }

        #endregion
        #region 标定控制

        public void btnStartDema_Click(object sender, EventArgs e)
        {

        }

        public void btnStopDema_Click(object sender, EventArgs e)
        {

        }

        public void 诊断信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void 诊断结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void btnClearCountShow_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region 保存查询数据
        Form_FindData formFindData;
        public void 查询数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Form_FindData.Count == 0)
            {
                formFindData = new Form_FindData();
                formFindData.MdiParent = formMain;
                formFindData.ControlBox = false;
                formFindData.Show();
            }

        }

        public void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Timer

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Server

        public Server server;
        //public Client client;
        private Thread acceptConn;
        private Thread AcceptClient1Data;

        void GenerateSever()
        {
            //this.server = new Server();  //创建服务器
            //this.server.listener.Start();  //开始监听
            //this.acceptConn = new Thread(new ThreadStart(this.server.Connection)); //新建一个线程用于接受请求连接
            //this.acceptConn.IsBackground = true;
            //this.acceptConn.Name = "检测客户端的连接并接受的线程";
            //this.acceptConn.Start(); //开始线程
            //timerServer.Enabled = true;
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (this.server.client1 != null)
            {
                if (this.AcceptClient1Data == null)  //如果线程没有初始化则先初始化
                {
                    this.AcceptClient1Data = new Thread(new ThreadStart(server.AccpetClient1Data));
                    this.AcceptClient1Data.IsBackground = true;
                    this.AcceptClient1Data.Name = "服务器检测客户端1是否发送准备消息";
                }
                if (this.AcceptClient1Data.ThreadState == (ThreadState.Background | ThreadState.Unstarted))  //如果线程没有启动则先启动,由于之前把线程的IsBackGround设置为true,所以这里要这样写
                {
                    this.AcceptClient1Data.Start();
                }
                labelStatus.Text = "连接到客户端";
                if (server.SendDataForClient("Jump", 1) == false)
                {
                    server.client1 = null;
                    AcceptClient1Data = null;
                }
                    
            }
            else
                labelStatus.Text = "没有客户端连接";
        }

        #endregion

        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            new FileSaveSerice().SaveStationsData(Stations);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            new QiniuYun.UpLoad().uploadStreamTest();
        }

        public Form_FindData formMyFindData;
        private void skinButton3_Click(object sender, EventArgs e)
        {
            var btn = sender as CCWin.SkinControl.SkinButton;
            var tag = Convert.ToInt32(btn.Tag);
            formMyFindData = new Form_FindData(Stations[tag]);
            formMyFindData.MdiParent = formMain;
            formMyFindData.ControlBox = false;
            formMyFindData.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QiniuYun.UpLoad().RefreshFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QiniuYun.UpLoad().uploadStreamTest("test.txt","test.txt");
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i<20 ;++i)
            {
                if(Stations[i].IsError == true)
                {
                    LabelStations[i].Text = "故障";
                    LabelStations[i].BackColor = Color.Red;
                }
                else
                {
                    if(Stations[i].IsNormal == true)
                    {
                        LabelStations[i].Text = "正常";
                        LabelStations[i].BackColor = Color.Lime;
                    }
                    else
                    {
                        LabelStations[i].Text = "报警";
                        LabelStations[i].BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            var btn = sender as SkinButton;
            btn.Text =  ComWithSqlServer.FindData();
        }
    }
}
