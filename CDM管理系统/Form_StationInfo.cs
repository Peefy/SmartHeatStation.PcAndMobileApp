using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;

using SmartHeatStationParaInfo;

namespace 流量计检定上位机
{
    public partial class Form_StationInfo : CCWin.CCSkinMain
    {

        string[] paraNames =
        {
            "一网参数",
            "二网高区参数",
            "二网中区参数",
            "二网低区参数",

            "水箱1参数",
            "水箱2参数",
            "水箱进水阀参数",
            "总调节阀参数",

            "流量热量表参数",
            "泵0参数",
            "泵1参数",
            "泵2参数",
            "泵3参数",
            "泵4参数",
            "泵5参数",
            "泵6参数",
            "泵7参数",
            "泵8参数",
            "泵9参数",
        };

        int[] visibeNumbers =
        {
            12,
            12,
            12,
            12,
            5,5,5,3,2,
            8,8,8,8,8,
            8,8,8,8,8
        };

        public static int Count = 0;
        private Station station;
        private int index;
        List<SkinLabel> Labels;
        List<SkinTextBox> TextBoxs;

        public Form_StationInfo(Station station, int index)
        {
            InitializeComponent();
            this.labelTime.Text = DateTime.Now.ToString();
            this.station = station;
            this.index = index;
            btnClose.Text = $"修改{station.Name}的参数:{paraNames[index]}";

            InitData();

        }

        public void InitData()
        {
            Labels = new List<SkinLabel>
            {   label0, label1, label2, label3,
                label4,label5,label6,label7,
                label8,label9,label10,label11,
            };
            TextBoxs = new List<SkinTextBox>
            {
                textBox0,textBox1,textBox2,textBox3,
                textBox4,textBox5,textBox6,textBox7,
                textBox8,textBox9,textBox10,textBox11,
            };
            foreach(var label in Labels)
            {
                label.Visible = false;
            }
            foreach (var textBox in TextBoxs)
            {
                textBox.Visible = false;
            }
            for (int i = 0; i < visibeNumbers[index]; ++i)
            {
                Labels[i].Visible = true;
                TextBoxs[i].Visible = true;
                switch(index)
                {
                    case 0:
                        Labels[i].Text = station.一网.ParaNames[i];
                        TextBoxs[i].Text = station.一网.ParaValues[i];
                        break;
                    case 1:
                        Labels[i].Text = station.二网高区.ParaNames[i];
                        TextBoxs[i].Text = station.二网高区.ParaValues[i];
                        break;
                    case 2:
                        Labels[i].Text = station.二网中区.ParaNames[i];
                        TextBoxs[i].Text = station.二网中区.ParaValues[i];
                        break;
                    case 3:
                        Labels[i].Text = station.二网低区.ParaNames[i];
                        TextBoxs[i].Text = station.二网低区.ParaValues[i];
                        break;
                    case 4:
                        Labels[i].Text = station.水箱.ParaNames[i];
                        TextBoxs[i].Text = station.水箱.ParaValues[i];
                        break;
                    case 5:
                        Labels[i].Text = station.水箱2.ParaNames[i];
                        TextBoxs[i].Text = station.水箱2.ParaValues[i];
                        break;
                    case 6:
                        Labels[i].Text = station.水箱进水阀.ParaNames[i];
                        TextBoxs[i].Text = station.水箱进水阀.ParaValues[i];
                        break;
                    case 7:
                        Labels[i].Text = station.总调节阀.ParaNames[i];
                        TextBoxs[i].Text = station.总调节阀.ParaValues[i];
                        break;
                    case 8:
                        Labels[0].Text = "流量";
                        TextBoxs[0].Text = station.流量;
                        Labels[1].Text = "累积热量";
                        TextBoxs[1].Text = station.累积热量;
                        break;
                    case 9:
                        Labels[i].Text = station.泵系列[0].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[0].ParaValues[i];
                        break;
                    case 10:
                        Labels[i].Text = station.泵系列[1].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[1].ParaValues[i];
                        break;
                    case 11:
                        Labels[i].Text = station.泵系列[2].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[2].ParaValues[i];
                        break;
                    case 12:
                        Labels[i].Text = station.泵系列[3].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[3].ParaValues[i];
                        break;
                    case 13:
                        Labels[i].Text = station.泵系列[4].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[4].ParaValues[i];
                        break;
                    case 14:
                        Labels[i].Text = station.泵系列[5].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[5].ParaValues[i];
                        break;
                    case 15:
                        Labels[i].Text = station.泵系列[6].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[6].ParaValues[i];
                        break;
                    case 16:
                        Labels[i].Text = station.泵系列[7].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[7].ParaValues[i];
                        break;
                    case 17:
                        Labels[i].Text = station.泵系列[8].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[8].ParaValues[i];
                        break;
                    case 18:
                        Labels[i].Text = station.泵系列[9].ParaNames[i];
                        TextBoxs[i].Text = station.泵系列[9].ParaValues[i];
                        break;
                }
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var number = visibeNumbers[index];
            string[] strParas = new string[number];
            for(int i = 0;i<number ;++i)
            {
                strParas[i] = TextBoxs[i].Text;
            }

            switch (index)
            {
                case 0:
                    station.一网.ParaValues = strParas;
                    break;
                case 1:
                    station.二网高区.ParaValues = strParas;
                    break;
                case 2:
                    station.二网中区.ParaValues = strParas;
                    break;
                case 3:
                    station.二网低区.ParaValues = strParas;
                    break;
                case 4:
                    station.水箱.ParaValues = strParas;
                    break;
                case 5:
                    station.水箱2.ParaValues = strParas;
                    break;
                case 6:
                    station.水箱进水阀.ParaValues = strParas;
                    break;
                case 7:
                    station.总调节阀.ParaValues = strParas;
                    break;
                case 8:
                    station.流量 = strParas[0];
                    station.累积热量 = strParas[0];
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    station.泵系列[index - 9].ParaValues = strParas;
                    break;
                }
            Form_MainShow.formMain.formMainShow.formMyFindData.InitData();
            this.Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }




    }
}
