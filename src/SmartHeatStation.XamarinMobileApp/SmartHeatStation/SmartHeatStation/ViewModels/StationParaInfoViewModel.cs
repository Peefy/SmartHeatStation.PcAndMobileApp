using SmartHeatStation.Models;
using SmartHeatStation.Models.ParaInfo;
using SmartHeatStation.Converters;
using SmartHeatStation.Helper;

using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class StationParaInfoViewModel : ListViewModelBase<ItemStationDetail>
    {
        ItemStationDetail item;
        List<StationCode> StationCodes => Apphelper.HomeTabPage.HomeView.ListViewModel.StationCodes;
        List<GatherData> GatherDatas => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherDatas;
        List<GatherError> GatherErrors => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherErrors;
        Dictionary<string, string> StationCode => StationCodes[Index].Dictionary;
        Dictionary<string, string> GatherData => GatherDatas[Index].Dictionary;

        int Index;

        //string userNameId => Apphelper.HomeTabPage.mineViewModel.UserNameId;

        public StationParaInfoViewModel(string title, ItemStationDetail pItem,int index) : base(title)
        {
            item = pItem;
            Index = index;
            var paraName = item.ParaName.Replace("参数", "");
            Title = Device.OnPlatform(
                paraName, 
                title + "." + paraName, 
                title + "." + paraName);
            InitializeAsync();

        }

        public async override void OnSelectItem(ItemStationDetail item)
        {
            if (item == null)
                return;           
        }

        public async override void OnRefresh(object obj)
        {
            IsBusy = true;
            await Task.Delay(300);
            await Task.Run(() =>
            {

            });
            IsBusy = false;
        }

        public async override Task InitializeAsync()
        {
            await Task.Run(() =>
            {
                var strParas = item.ParaValue.Split('|');
                Items.Clear();
                #region 区域
                if (item.ParaName == "一次网参数" || item.ParaName == "二次高区参数" ||
                    item.ParaName == "二次中区参数" || item.ParaName == "二次低区参数")
                {
                    string i = item.Id;
                    i = i.Replace("Area","");
                    if(StationCode[$"sp{i}visible"] == "True")
                    //if(true)
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "供水压力",
                            Id = "供水压力",
                            ParaValue = string.Format("当前值:{0}Mpa\r\n上限值:{1}Mpa\r\n下限值:{2}Mpa",
                                            strParas[10], strParas[0], strParas[1]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_sp{i}sign"])
                        });
                    }

                    if (StationCode[$"lp{i}visible"] == "True")
                    //if(true)
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "回水压力",
                            Id = "回水压力",
                            ParaValue = string.Format("当前值:{0}Mapa\r\n上限值:{1}Mpa\r\n下限值:{2}Mpa",
                                            strParas[11], strParas[2], strParas[3]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_lp{i}sign"])
                        });
                    }

                    if (StationCode[$"st{i}visible"] == "True")
                    //if(true)
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "供水温度",
                            Id = "供水温度",
                            ParaValue = string.Format("当前值:{0}℃\r\n上限值:{1}℃\r\n下限值:{2}℃ ",
                                            strParas[12], strParas[4], strParas[5]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_st{i}sign"])
                        });
                    }

                    if (StationCode[$"lt{i}visible"] == "True")
                    //if(true)
                    {

                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "回水温度",
                            Id = "回水温度",
                            ParaValue = string.Format("当前值:{0}℃\r\n上限值:{1}℃\r\n下限值:{2}℃",
                                            strParas[13], strParas[6], strParas[7]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_lt{i}sign"])
                        });

                    }

                    if (StationCode[$"flow{i}visible"] == "True")
                    //if(true)
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "流量",
                            Id = "流量",
                            ParaValue = string.Format("当前值:{0}\r\n上限值:{1}\r\n下限值:{2}",
                                            strParas[14], strParas[8], strParas[9]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_flow{i}sign"])
                        });
                    }

                }
                #endregion
                #region 水箱
                else if (item.ParaName == "水箱参数")
                {
                    float waterboxHeight = float.Parse(strParas[0]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱真实高度",
                        Id = "水箱真实高度",
                        ParaValue = string.Format("{0}cm",
                            strParas[0]),
                    });
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱液位高度",
                        Id = "水箱液位高度",
                        ParaValue = string.Format("{0}cm",
                            strParas[7]),

                    });

                    float rate = float.Parse(strParas[1]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱补水比例和高度",
                        Id = "水箱补水比例和高度",
                        ParaValue = string.Format("补水高度:{0}cm\r\n补水比例:{1}",
                            rate * waterboxHeight,rate),
                    });
                    rate = float.Parse(strParas[2]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱停水比例和高度",
                        Id = "水箱停水比例和高度",
                        ParaValue = string.Format("停水高度:{0}cm\r\n停水比例:{1}",
                            rate * waterboxHeight, rate),
                    });
                    rate = float.Parse(strParas[3]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱上限比例和高度",
                        Id = "水箱上限比例和高度",
                        ParaValue = string.Format("上限高度:{0}cm\r\n上限比例:{1}",
                            rate * waterboxHeight, rate),
                    });
                    rate = float.Parse(strParas[4]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "水箱下限比例和高度",
                        Id = "水箱下限比例和高度",
                        ParaValue = string.Format("下限高度:{0}cm\r\n下限比例:{1}",
                            rate * waterboxHeight, rate),
                    });
                }
                #endregion
                //else if (item.ParaName == "补水压力设备参数")
                //{

                //}
                #region 总调节阀
                else if (item.ParaName == "总调节阀参数")
                {
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "开度上限",
                        Id = "开度上限",
                        ParaValue = string.Format("{0}",
                            strParas[0]),
                    });

                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "开度下限",
                        Id = "开度下限",
                        ParaValue = string.Format("{0}",
                            strParas[1]),
                    });
                    float percent = float.Parse(strParas[2]);
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "开度百分比",
                        Id = "开度百分比",
                        ParaValue = string.Format("{0}%",
                            percent * 100),
                    });

                }
                #endregion
                #region 热量流量表
                else if (item.ParaName == "热量流量表1参数" || item.ParaName == "热量流量表2参数")
                {
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "总热量",
                        Id = "总热量",
                        ParaValue = string.Format("{0}GJ",
                            strParas[0]),
                    });

                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "总流量",
                        Id = "总流量",
                        ParaValue = string.Format("{0}m3/h",
                            strParas[1]),
                    });
                }
                #endregion
                #region 入出口温度
                else if (item.ParaName == "入出口温度1参数" || item.ParaName == "入出口温度2参数")
                {
                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "入口温度",
                        Id = "入口温度",
                        ParaValue = string.Format("{0}℃",
                            strParas[0]),
                    });

                    Items.Add(new ItemStationDetail()
                    {
                        ParaName = "出口温度",
                        Id = "出口温度",
                        ParaValue = string.Format("{0}℃",
                            strParas[1]),
                    });
                }
                #endregion
                #region 变频控制
                else if (item.ParaName.Contains("变频控制") == true)
                {
                    string ii = item.Id;
                    ii = ii.Replace("FC", "");
                    int i = int.Parse(ii);
                    if(i <= 6)
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "频率",
                            Id = "频率",
                            ParaValue = string.Format("{0}Hz",
                                strParas[0]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_fc{i}sign"])
                        });
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "转速",
                            Id = "转速",
                            ParaValue = string.Format("{0}r/min",
                                strParas[1]),
                        });
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "电流",
                            Id = "电流",
                            ParaValue = string.Format("{0}A",
                                strParas[2]),
                        });
                    }
                    else
                    {
                        Items.Add(new ItemStationDetail()
                        {
                            ParaName = "频率",
                            Id = "频率",
                            ParaValue = string.Format("{0}Hz",
                                strParas[0]),
                            TextColor = (Color)new BoolToWarningColorConverter().
                                StringConvert(GatherData[$"alarm_fc{i}sign"])
                        });
                    }
                }
                #endregion
            });
            IsInitialize = true;
        }

    }
}
