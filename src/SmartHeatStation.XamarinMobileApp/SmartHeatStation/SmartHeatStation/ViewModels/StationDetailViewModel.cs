using SmartHeatStation.Helper;
using SmartHeatStation.Models;
using SmartHeatStation.Models.ParaInfo;
using SmartHeatStation.Converters;

using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class StationDetailViewModel: ListViewModelBase<ItemStationDetail>
    {

        List<StationCode> StationCodes => Apphelper.HomeTabPage.HomeView.ListViewModel.StationCodes;
        List<GatherData> GatherDatas => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherDatas;
        List<GatherError> GatherErrors => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherErrors;
        Dictionary<string,string> StationCode => StationCodes[Index].Dictionary;
        Dictionary<string, string> GatherData => GatherDatas[Index].Dictionary;
        Dictionary<string, string> GatherError => GatherErrors[Index].Dictionary;

        int Index;

        public StationDetailViewModel(string title,int index):base(title)
        {
            Index = index;
            Title = Title;
        }

        public async override void OnRefresh(object obj)
        {
            IsBusy = true;
            await Task.Delay(300);
            await Task.Run(async () =>
            {
                
            });
            IsBusy = false;
        }

        static bool itemTapBusy;
        public async override void OnSelectItem(ItemStationDetail item)
        {
            if (item == null)
                return;
            await Apphelper.HomeTabPage.Navigation.
                PushAsync(new Pages.StationParaInfoPage(
                    new StationParaInfoViewModel(Title,item,Index)));

        }

        public async override Task InitializeAsync()
        {
            if (IsInitialize == true)
                return;
            await Task.Delay(100);
            await Task.Run(async () => {

                var getParaValue = new GetParaValue(StationCode, GatherData,GatherError);
                #region 一次网
                if (StationCodes[Index].Exist一次网() == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "一次网参数",
                        ParaValue = getParaValue.Num一次网,
                        Id = "Area1",
                        TextColor = (Color)new BoolToWarningColorConverter().
                            BoolConvert(getParaValue.Alarm一次网)
                        
                    });
                }
                #endregion
                #region 二次低区
                if (StationCodes[Index].Exist二次低区() == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "二次低区参数",
                        ParaValue = getParaValue.Num二次低区,
                        Id = "Area2",
                        TextColor = (Color)new BoolToWarningColorConverter().
                            BoolConvert(getParaValue.Alarm二次低区)
                    });
                }
                #endregion
                #region 二次中区
                if (StationCodes[Index].Exist二次中区() == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "二次中区参数",
                        ParaValue = getParaValue.Num二次中区,
                        Id = "Area3",
                        TextColor = (Color)new BoolToWarningColorConverter().
                            BoolConvert(getParaValue.Alarm二次中区)
                    });
                }
                #endregion
                #region 二次高区
                if (StationCodes[Index].Exist二次高区()== true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "二次高区参数",
                        ParaValue = getParaValue.Num二次高区,
                        Id = "Area4",
                        TextColor = (Color)new BoolToWarningColorConverter().
                            BoolConvert(getParaValue.Alarm二次高区)
                    });
                }
                #endregion
                #region 水箱
                if (StationCodes[Index].Exist水箱() == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "水箱参数",
                        ParaValue = getParaValue.Num水箱,
                        TextColor = (Color)new BoolToWarningColorConverter().
                            BoolConvert(getParaValue.Alarm水箱)
                    });
                }
                #endregion
                #region 补水压力设备
                if (false)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "补水压力设备参数",
                        ParaValue = getParaValue.Num补水压力设备
                    });
                }
                #endregion
                #region 总调节阀
                if (true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "总调节阀参数",
                        ParaValue = getParaValue.Num总调节阀
                    });
                }
                #endregion
                #region 热量流量表
                if (StationCodes[Index].Exist热量流量表(1) == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "热量流量表1参数",
                        ParaValue = getParaValue.Num热量流量表1
                    });
                }
                if (StationCodes[Index].Exist热量流量表(2) == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "热量流量表2参数",
                        ParaValue = getParaValue.Num热量流量表2
                    });
                }
                #endregion
                #region 入出口温度参数
                if (StationCodes[Index].Exist入出口温度(1) == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "入出口温度1参数",
                        ParaValue = getParaValue.Num入出口温度1
                    });
                }
                if (StationCodes[Index].Exist入出口温度(2) == true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "入出口温度2参数",
                        ParaValue = getParaValue.Num入出口温度2
                    });
                }
                #endregion
                #region 变频控制1-6
                for (int i = 1;i<=6 ;++i)
                {
                    if (StationCodes[Index].Exist变频控制(i))
                    {
                        await AddItemAsync(new ItemStationDetail()
                        {
                            ParaName = $"变频控制{i}参数",
                            ParaValue = getParaValue.GetNum变频控制Para(i),
                            Id = $"FC{i}",
                            TextColor = (Color)new BoolToWarningColorConverter().
                                BoolConvert(getParaValue.GeAlarm变频控制Para(i))
                        });
                    }
                }
                #endregion
                #region 变频控制7-10
                for (int i = 7; i <= 10; ++i)
                {
                    if (StationCodes[Index].Exist变频控制(i))
                    {
                        await AddItemAsync(new ItemStationDetail()
                        {
                            ParaName = $"变频控制{i}参数",
                            ParaValue = getParaValue.GetNum变频控制Para(i),
                            Id = $"FC{i}",
                            TextColor = (Color)new BoolToWarningColorConverter().
                                BoolConvert(getParaValue.GeAlarm变频控制Para(i))
                        });
                    }
                }
                #endregion
                #region 错误标志
                if (true)
                {
                    await AddItemAsync(new ItemStationDetail()
                    {
                        ParaName = "错误标志参数",
                        ParaValue = getParaValue.Num错误标志
                    });
                }
                #endregion
            });
            IsInitialize = true;
        }

    }
}
