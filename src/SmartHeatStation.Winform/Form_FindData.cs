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
using 流量计检定上位机.SmartHeatStation.Models;

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

        GatherData mGatherData;
        StationCode mStationCode;
        GatherError mGatherError;
        GetParaValue mGetParaValue;

        public Form_FindData(GatherData pGatherData,StationCode pStationCode,GatherError pGatherError)
        {
            InitializeComponent();
            mGatherData = pGatherData;
            mStationCode = pStationCode;
            mGatherError = pGatherError;
            mGetParaValue = new GetParaValue(pStationCode.Dictionary, 
                pGatherData.Dictionary, pGatherError.Dictionary);

            this.labelTime.Text = DateTime.Now.ToString();
            InitData();
            Count++;
        }

        public void InitData()
        {
            Label一网.Text = mGetParaValue.Num一次网.ToString();
            Label一网.ForeColor = BoolIsNormalConverter(!mGetParaValue.Alarm一次网);

            Label二网高区.Text = mGetParaValue.Num二次高区.ToString();
            Label二网高区.ForeColor = BoolIsNormalConverter(!mGetParaValue.Alarm二次高区);

            Label二网中区.Text = mGetParaValue.Num二次中区.ToString();
            Label二网中区.ForeColor = BoolIsNormalConverter(!mGetParaValue.Alarm二次中区);

            Label二网低区.Text = mGetParaValue.Num二次低区.ToString();
            Label二网低区.ForeColor = BoolIsNormalConverter(!mGetParaValue.Alarm二次低区);

            Label水箱.Text = mGetParaValue.Num水箱.ToString();
            Label水箱.ForeColor = BoolIsErrorConverter(mGetParaValue.Alarm水箱);

            Label总调节阀.Text = mGetParaValue.Num总调节阀.ToString();

            Label热量流量表.Text = mGetParaValue.Num热量流量表1.ToString();

            Label泵0.Text = mGetParaValue.GetNum变频控制Para(1).ToString();
            Label泵0.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(1));

            Label泵1.Text = mGetParaValue.GetNum变频控制Para(2).ToString();
            Label泵1.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(2));
            Label泵2.Text = mGetParaValue.GetNum变频控制Para(3).ToString();
            Label泵2.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(3));
            Label泵3.Text = mGetParaValue.GetNum变频控制Para(4).ToString();
            Label泵3.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(4));
            Label泵4.Text = mGetParaValue.GetNum变频控制Para(5).ToString();
            Label泵4.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(5));
            Label泵5.Text = mGetParaValue.GetNum变频控制Para(6).ToString();
            Label泵5.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(6));
            Label泵6.Text = mGetParaValue.GetNum变频控制Para(7).ToString();
            Label泵6.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(7));
            Label泵7.Text = mGetParaValue.GetNum变频控制Para(8).ToString();
            Label泵7.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(8));
            Label泵8.Text = mGetParaValue.GetNum变频控制Para(9).ToString();
            Label泵8.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(9));
            Label泵9.Text = mGetParaValue.GetNum变频控制Para(10).ToString();
            Label泵9.ForeColor = BoolIsErrorConverter(mGetParaValue.GeAlarm变频控制Para(10));
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
            //var label = sender as SkinLabel;
            //var index = Convert.ToInt32(label.Tag);
            //formStationInfo = new Form_StationInfo(station,index);
            //formStationInfo.MdiParent = Form_MainShow.formMain;
            //formStationInfo.ControlBox = false;
            //formStationInfo.Show();
        }
    }
}
