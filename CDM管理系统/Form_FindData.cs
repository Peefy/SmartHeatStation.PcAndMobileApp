using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using SmartHeatStationParaInfo;
using CCWin.SkinControl;

namespace 流量计检定上位机
{
    public partial class Form_FindData : CCWin.CCSkinMain
    {
        public static int Count = 0;
        int FindCount = 0;
        int CountShow = 1;

        public Form_FindData()
        {
            InitializeComponent();
            this.labelTime.Text = DateTime.Now.ToString();
            Count++;
        }
        Station station;

        public Form_FindData(Station pStation)
        {
            InitializeComponent();
            station = pStation;

            btnClose.Text = "关闭" + station.Name;
            this.labelTime.Text = DateTime.Now.ToString();
            InitData();         
            Count++;
        }

        public void InitData()
        {
            Label一网.Text = station.一网.ToString();
            Label一网.ForeColor = BoolIsNormalConverter(station.一网.IsNormal);

            Label二网高区.Text = station.二网高区.ToString();
            Label二网高区.ForeColor = BoolIsNormalConverter(station.二网高区.IsNormal);

            Label二网中区.Text = station.二网中区.ToString();
            Label二网中区.ForeColor = BoolIsNormalConverter(station.二网中区.IsNormal);

            Label二网低区.Text = station.二网低区.ToString();
            Label二网低区.ForeColor = BoolIsNormalConverter(station.二网低区.IsNormal);

            Label水箱.Text = station.水箱.ToString();
            Label水箱.ForeColor = BoolIsErrorConverter(station.水箱.IsError);

            Label水箱2.Text = station.水箱2.ToString();
            Label水箱2.ForeColor = BoolIsErrorConverter(station.水箱2.IsError);

            Label水箱进水阀.Text = station.水箱进水阀.ToString();
            Label水箱进水阀.ForeColor = BoolIsErrorConverter(station.水箱进水阀.IsError);

            Label总调节阀.Text = station.总调节阀.ToString();
            Label总调节阀.ForeColor = BoolIsErrorConverter(station.总调节阀.IsError);

            Label热量流量表.Text = station.流量 + "|" + station.累积热量 + "|";

            Label泵0.Text = station.泵系列[0].ToString();
            Label泵0.ForeColor = BoolIsErrorConverter(station.泵系列[0].IsError);

            Label泵1.Text = station.泵系列[1].ToString();
            Label泵1.ForeColor = BoolIsErrorConverter(station.泵系列[1].IsError);
            Label泵2.Text = station.泵系列[2].ToString();
            Label泵2.ForeColor = BoolIsErrorConverter(station.泵系列[2].IsError);
            Label泵3.Text = station.泵系列[3].ToString();
            Label泵3.ForeColor = BoolIsErrorConverter(station.泵系列[3].IsError);
            Label泵4.Text = station.泵系列[4].ToString();
            Label泵4.ForeColor = BoolIsErrorConverter(station.泵系列[4].IsError);
            Label泵5.Text = station.泵系列[5].ToString();
            Label泵5.ForeColor = BoolIsErrorConverter(station.泵系列[5].IsError);
            Label泵6.Text = station.泵系列[6].ToString();
            Label泵6.ForeColor = BoolIsErrorConverter(station.泵系列[6].IsError);
            Label泵7.Text = station.泵系列[7].ToString();
            Label泵7.ForeColor = BoolIsErrorConverter(station.泵系列[7].IsError);
            Label泵8.Text = station.泵系列[8].ToString();
            Label泵8.ForeColor = BoolIsErrorConverter(station.泵系列[8].IsError);
            Label泵9.Text = station.泵系列[9].ToString();
            Label泵9.ForeColor = BoolIsErrorConverter(station.泵系列[9].IsError);
        }

        Color BoolIsNormalConverter(bool value)
        {
            if (value == true)
                return Color.Black;
            return Color.Yellow;
        }

        Color BoolIsErrorConverter(bool value)
        {
            if (value == true)
                return Color.Red;
            return Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form_MainShow.formMain.formMainShow.timer1_Tick(null, null);
            this.Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        string getMonthStr(decimal val)
        {
            if (val < 10)
                return "0" + val.ToString();
            else
                return val.ToString();
        }

        string getDayStr(decimal val)
        {
            if (val < 10)
                return "0" + val.ToString();
            else
                return val.ToString();
        }

        private void Form_FindData_Load(object sender, EventArgs e)
        {


        }

        private void Form_FindData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Count--;
        }

        public Form_StationInfo formStationInfo;
        private void Label一网_Click(object sender, EventArgs e)
        {
            var label = sender as SkinLabel;
            var index = Convert.ToInt32(label.Tag);
            formStationInfo = new Form_StationInfo(station,index);
            formStationInfo.MdiParent = Form_MainShow.formMain;
            formStationInfo.ControlBox = false;
            formStationInfo.Show();
        }
    }
}
