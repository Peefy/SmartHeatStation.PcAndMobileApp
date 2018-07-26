
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Xamarin.Forms;

using SmartHeatStation.Models;
using SmartHeatStation.Models.ParaInfo;
using SmartHeatStation.Services;
using SmartHeatStation.Helper;

namespace SmartHeatStation.ViewModels
{
    public class HomeViewListViewModel : ListViewModelBase<Item>
    {
        int StationNums;
        protected readonly IDownLoad DownLoadService;

        public List<GatherData> GatherDatas { get; set;}
        public List<StationCode> StationCodes { get; set;}
        public List<GatherError> GatherErrors { get; set;}

        public int DownLoadInterval { get; set; } = 28;

        public HomeViewListViewModel(string title) : base(title)
        {
            Title = "大连金州智慧换热站";
            GatherDatas = new List<GatherData>();
            StationCodes = new List<StationCode>();
            GatherErrors = new List<GatherError>();
            DownLoadService = DependencyService.Get<IDownLoad>();
            InitializeAsync();
            //Task.Run(async () =>
            //{
            //    while(true)
            //    {
            //        await OnDownLoad(null);
            //        await Task.Delay(DownLoadInterval * 1000);
            //    }           
            //});
        }

        public async override Task InitializeAsync()
        {
            if (IsInitialize == true)
                return;
            await Task.Run(async ()=> {
                for (int i = 0; i < 50 - 7; ++i)
                {
                    await AddItemAsync(new Item()
                    {
                        StationName = "换热站" ,
                        Id = i.ToString()
                    });
                    GatherDatas.Add(new GatherData());
                    StationCodes.Add(new StationCode());
                    GatherErrors.Add(new GatherError());
                }
                    
            });
            IsInitialize = true;
        }

        public async override void OnRefresh(object obj)
        {
            IsBusy = true;
            int delayTime = Device.OnPlatform(10, 300, 300);
            await Task.Delay(delayTime);
            await OnDownLoad(null);
            IsBusy = false;
        }

        public async override void OnSelectItem(Item item)
        {
            if (item == null)
                return;
            if (IsInitialize == false)
                return;
            if (item.StationName == "通信异常！" || item.StationName == "查询时间无数据")
                return;
            int index;
            try
            {
                index = int.Parse(item.Id);
            }
            catch
            {
                return;
            }
            var itemViewModel = new StationDetailViewModel(item.StationName,index);
            Apphelper.HomeTabPage.RepportViewModel.Items.Add(string.Format("您在{0}查看了{1}",
                DateTime.Now, item.StationName));
            Apphelper.HomeTabPage.RepportView.RefreshData();

            await Apphelper.HomeTabPage.Navigation.PushAsync(
                new Pages.StationDetailPage(itemViewModel));
        }

        const string url = "http://oios713sb.bkt.clouddn.com/";
        async Task OnDownLoad(object obj)
        {
            string str = "";
            string realURL = url + "stations" + TimerHelper.GetUpLoadTime() + ".txt";
            //string realURL = "http://oios713sb.bkt.clouddn.com/stations2017033012540.txt";
            str = await DownLoadService.DownLoadString(realURL);
            if (str != "Error")
            {
                var paraTotals = str.Split('@');

                var gatherDatasTotal = paraTotals[0];
                var stationCodesTotal = paraTotals[1];
                var gatherErrorsTotal = paraTotals[2];

                var gatherDatas = gatherDatasTotal.Split('&');
                var stationCodes = stationCodesTotal.Split('&');
                var gatherErrors = gatherErrorsTotal.Split('&');

                StationNums = stationCodes.Length - 1;

                for(int i = 0; i< StationNums - Items.Count ; ++i)
                {
                    await AddItemAsync(new Item()
                    {
                        StationName = "正在获取数据...",
                        Id = (i + Items.Count).ToString()
                    });
                    GatherDatas.Add(new GatherData());
                    StationCodes.Add(new StationCode());
                    GatherErrors.Add(new GatherError());
                }
                var oldItems = new ObservableCollection<Item>();
                for (int i = 0; i < StationNums; ++i)
                {
                    oldItems.Add(new Item()
                    {
                        Id = i.ToString()
                    });
                }
                for (int i = 0; i < StationNums ; ++i)
                {
                    var paraStrSC = stationCodes[i].Split('|');
                    StationCodes[i].Paras = paraStrSC;

                    var paraStrGD = gatherDatas[i].Split('|');
                    GatherDatas[i].Paras = paraStrGD;

                    var paraStrGE = gatherErrors[i].Split('|');
                    GatherErrors[i].Paras = paraStrGE;

                    oldItems[i].StationName = StationCodes[i].Dictionary["station"].Split(')')[1];
                    oldItems[i].DisplaySort = StationCodes[i].Dictionary["dispsort"];
                    SetStationStatus(oldItems[i],
                        GatherDatas[i].Dictionary["alarmsign"],
                        GatherDatas[i].Dictionary["errsign"]);
                    //IsInitialize = true;
                }
                ItemsSort(oldItems);
            }
            else
            {
                foreach(var item in Items)
                {
                    item.StationStatus = StationStatusEnum.Unkown;
                    item.IsError = false;
                    item.IsAlarm = false;
                    item.StationName = TimerHelper.IsCheckNotNow == false ? "通信异常！" : "查询时间无数据";
                }
            }          
        }

        void ItemsSort(ObservableCollection<Item> oldItems)
        {
            var NewItems = from item in oldItems
                           orderby item.DisplaySort ascending /*descending*/
                           select item; 
            int i = 0;
            foreach (var newItem in NewItems)
            {
                Items[i] = newItem;
                i++;
            }           
        }

        void SetStationStatus(Item item, string alarmSign, string errorSign)
        {
            item.IsError = errorSign == "True";
            item.IsAlarm = alarmSign == "True";
            if (item.IsError == false && item.IsAlarm == false)
                item.StationStatus = StationStatusEnum.Running;
            else
                item.StationStatus = StationStatusEnum.Unkown;
        }
    }
}
