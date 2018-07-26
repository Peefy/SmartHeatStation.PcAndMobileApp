
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System;
using System.Drawing;

using SmartHeatStationService.SqlServer;
using SmartHeatStationService.Service;
using SmartHeatStationService.Models;
using SmartHeatStationService.Sqlite;

namespace SmartHeatStationService
{
    public partial class FormMain : Form
    {

        ComWithSql ComWithSqlServer;
        ComWithSqlite ComWithSqliteServer;
        Thread UpLoadThread;
        Thread InitThread;
        List<StationCode> StationCodes;
        List<GatherData> GatherDatas;
        List<GatherError> GatherErrors;
        delegate void InvokeCallback(bool result);

        Size NormalSize = new Size(400, 200);
        Size DescriptionSize = new Size(400, 300);

        bool isConnect;

        public FormMain()
        {
            InitializeComponent();
            ComWithSqliteServer = new ComWithSqlite();
            this.Size = NormalSize;

            ComWithSqlServer = new ComWithSql();
            ToolStripMenuItemAuto.Checked = FileService.ReadApplicationConfig();
            FileService.ReadUserConfig(ComWithSqlServer);
            isConnect = ComWithSqlServer.IsConnect;
            labelServerName.Text = ComWithSqlServer.ServerName;
            labelDataBaseName.Text = ComWithSqlServer.DatabaseName;
            labelUidName.Text = ComWithSqlServer.UidName;
            labelPwdName.Text = ComWithSqlServer.PwdName;
        }

        void Init()
        {

            if (isConnect == false)
                return;
            if (ToolStripMenuItemAuto.Checked == false)
                return;

            labelStatus.Visible = true;
            labelStatus.Text = "正在连接数据库......";
            progressBar1.Visible = true;
            progressBar1.Value = 90;
            panelSqlServer.Enabled = false;
            ToolStripMenuItemConnectServer.Enabled = false;

            InitThread = new Thread(new ThreadStart(() =>
            {
                var result = ComWithSqlServer.OpenDatabase();
                RenewData(result);

            }));
            InitThread.Start();

        }

        private void RenewData(bool result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new InvokeCallback(RenewData), new object[] { result });
            }
            else
            {
                if (result == true)
                {
                    MessageBox.Show("数据库连接成功!\r\n点击确定按钮开始上传数据");
                }                   
                else
                {
                    MessageBox.Show("数据库连接失败！\r\n软件退出");
                    this.WindowState = FormWindowState.Minimized;
                    Close();
                    return;
                }
                labelStatus.Text = "数据库连接成功！";
                progressBar1.Visible = false;
                ToolStripMenuItemConnectServer.Enabled = false;
                panelSqlServer.Enabled = false;

                StationCodes = new List<StationCode>();
                GatherDatas = new List<GatherData>();
                GatherErrors = new List<GatherError>();

                textBox1.Text = ComWithSqlServer.FindStationCode(StationCodes);
                textBox2.Text = ComWithSqlServer.FindGatherData(GatherDatas);
                textBox1.Text = ComWithSqlServer.FindGatherErrors(GatherErrors);

                UpLoadThread = new Thread(new ThreadStart(() =>
                {
                    while (true)
                    {
                        ComWithSqlServer?.FindStationCode(StationCodes);
                        ComWithSqlServer?.FindGatherData(GatherDatas);
                        ComWithSqlServer?.FindGatherErrors(GatherErrors);
                        FileService.SaveStationsData(GatherDatas, StationCodes,GatherErrors);
                        Thread.Sleep(1000);
                        new QiniuYun.UpLoad().UploadStreamTest();
                        Thread.Sleep(25000);
                    }
                }));
                UpLoadThread.Start();
                HideFormToTuoPan();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                e.Cancel = true;
                this.HideFormToTuoPan();
            }
            ApplicationCloseDoEvent();
        
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Init();
        }

        void HideFormToTuoPan()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;  //不显示在系统任务栏
            notifyIcon1.Visible = true;  //托盘图标可见
            notifyIcon1.ShowBalloonTip(1000);          
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;  //显示在系统任务栏
            this.WindowState = FormWindowState.Normal;  //还原窗体
            notifyIcon1.Visible = false;  //托盘图标隐藏
        }

        private void toolStripMenuItemNotHideTuoPan_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;  //显示在系统任务栏
            this.WindowState = FormWindowState.Normal;  //还原窗体
            notifyIcon1.Visible = false;  //托盘图标隐藏
        }

        private void toolStripMenuItemExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemhide_Click(object sender, EventArgs e)
        {
            HideFormToTuoPan();
        }

        private void toolStripMenuItemEixt_Click(object sender, EventArgs e)
        {
            ApplicationCloseDoEvent();
            this.WindowState = FormWindowState.Minimized;
            Application.Exit();
        }

        private Point mPoint = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        void ApplicationCloseDoEvent()
        {
            if(ComWithSqlServer != null)
                FileService.SaveUserConfig(ComWithSqlServer);
            FileService.SaveApplicationConfig(ToolStripMenuItemAuto.Checked);
            notifyIcon1.Visible = false;
            #region 释放所有资源
            if (ComWithSqlServer != null)
            {
                ComWithSqlServer?.CloseDatabase();
                ComWithSqlServer = null;
            }
            if (UpLoadThread != null)
            {
                UpLoadThread.Abort();
                UpLoadThread = null;
            }
            if (InitThread != null)
            {
                InitThread.Abort();
                InitThread = null;
            }
            if(ComWithSqliteServer != null)
            {
                ComWithSqliteServer.Close();
                ComWithSqliteServer = null;
            }
            #endregion

        }

        private void ToolStripMenuItemConnectServer_Click(object sender, EventArgs e)
        {

            ComWithSqlServer.ServerName = labelServerName.Text;
            ComWithSqlServer.DatabaseName = labelDataBaseName.Text;
            ComWithSqlServer.UidName = labelUidName.Text;
            ComWithSqlServer.PwdName = labelPwdName.Text;

            labelStatus.Visible = true;
            labelStatus.Text = "正在连接数据库......";
            progressBar1.Visible = true;
            progressBar1.Value = 90;

            panelSqlServer.Enabled = false;
            ToolStripMenuItemConnectServer.Enabled = false;

            InitThread = new Thread(new ThreadStart(() =>
            {
                var result = ComWithSqlServer.OpenDatabase();
                RenewData(result);

            }));
            InitThread.Start();
        }

        private void ToolStripMenuItemAuto_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemAuto.Checked = !ToolStripMenuItemAuto.Checked;
        }

        bool isNormalSize = true;
        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNormalSize = !isNormalSize;
            this.Size = isNormalSize == true ?NormalSize:DescriptionSize;
        }

        private void 数据存入SQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread( new ThreadStart(()=> 
            {
                ComWithSqliteServer.InsertData(StationCodes);
            })).Start();           
        }
    }
}
