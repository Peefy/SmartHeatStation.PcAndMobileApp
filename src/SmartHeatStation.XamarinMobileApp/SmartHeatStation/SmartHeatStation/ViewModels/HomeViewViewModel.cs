using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;

using SmartHeatStation.Models;
using SmartHeatStation.Services;
using SmartHeatStation.Helper;
using SmartHeatStation.Models.ParaInfo;


namespace SmartHeatStation.ViewModels
{
    public class HomeViewViewModel :ViewModelBase
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public ICommand ItemSelectedCommand => new Command<Item>(OnSelectItem);
        public ICommand LoadMoreCommand => new Command(LoadmoreItem);
        public ICommand ChangeItemCommad => new Command<Item>(OnChangeItem);
        public ICommand DeleteItemCommad => new Command<Item>(OnDeleteItem);
        protected readonly IDownLoad DownLoadService;
        public List<Station> Stations;

        int StationNums;

        public HomeViewViewModel()
        {
            Title = "大连金州智慧换热站";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            DownLoadService = DependencyService.Get<IDownLoad>();

            MessagingCenter.Subscribe<Pages.NewStationPage, Item>(this, 
                Utils.MessengerKeys.NewStation, async (obj, item) =>
            {
                var _item = item as Item;
                AddNewItem(_item);
                await DataStore.AddItemAsync(_item);
            });

            #region 站类型定义
            Stations = new List<Station>
            {
                new Station() {Name = "阿尔滨站" },
                new Station() {Name = "金渤海景站" },
                new Station() {Name = "南山站" },
                new Station() {Name = "金山站" },
                new Station() {Name = "政府站" },

                new Station() {Name = "龙王站" },
                new Station() {Name = "自来水站" },
                new Station() {Name = "南棉站" },
                new Station() {Name = "盐场站" },
                new Station() {Name = "金海国际" },

                new Station() {Name = "北京郡站" },
                new Station() {Name = "光明西站" },
                new Station() {Name = "金海国际站" },
                new Station() {Name = "金连领地站" },
                new Station() {Name = "金山名苑站" },

                new Station() {Name = "欧美亚站" },
                new Station() {Name = "铁路站" },
                new Station() {Name = "五一站" },
                new Station() {Name = "于家洼站" },
                new Station() {Name = "环保站" },
                                new Station() {Name = "阿尔滨站" },
                new Station() {Name = "金渤海景站" },
                new Station() {Name = "南山站" },
                new Station() {Name = "金山站" },
                new Station() {Name = "政府站" },

                new Station() {Name = "龙王站" },
                new Station() {Name = "自来水站" },
                new Station() {Name = "南棉站" },
                new Station() {Name = "盐场站" },
                new Station() {Name = "金海国际" },

                new Station() {Name = "北京郡站" },
                new Station() {Name = "光明西站" },
                new Station() {Name = "金海国际站" },
                new Station() {Name = "金连领地站" },
                new Station() {Name = "金山名苑站" },

                new Station() {Name = "欧美亚站" },
                new Station() {Name = "铁路站" },
                new Station() {Name = "五一站" },
                new Station() {Name = "于家洼站" },
                new Station() {Name = "环保站" },

            };
            RestoreState(Application.Current.Properties);
            #endregion

            OnDownLoad(null);
            Device.StartTimer(TimeSpan.FromSeconds(20), () =>
            {
                OnDownLoad(null);
                return true;
            });

            ConnectServer();

        }

        bool isShowAlertIng = false;
        async void ConnectServer()
        {
            if (ConnectService.SendMessage("ok") == true)
                return;
            var result = await ConnectService.ConnectAsync("192.168.223.195", 8181);
            if (result == true)
                await DialogService.ShowAlertAsync("连接服务器成功!");
        }

        const string url = "http://oios713sb.bkt.clouddn.com/";
        async Task OnDownLoad(object obj)
        {
            //DateTime[] loadTimes = TimerHelper.GetUpLoadTimes();
            string str = "";
            //string realURL = url + "stations" + TimerHelper.GetUpLoadTime() + ".txt";
            string realURL = "http://oios713sb.bkt.clouddn.com/stations2017032916050.txt";
            str = await DownLoadService.DownLoadString(realURL);

            if (str != "Error")
            {

                var paraTotals = str.Split('@');
                var gatherDatasTotal = paraTotals[0];
                var stationCodesTotal = paraTotals[1];
                var gatherDatas = gatherDatasTotal.Split('&');
                var stationCodes = stationCodesTotal.Split('&');
                StationNums = stationCodes.Length - 1;

                for (int i = 0;i < StationNums; ++i)
                {
                    var paraStr = stationCodes[i].Split('|');
                    Items[i].StationName = paraStr[0];
                }
            }
            else
            {
                for (int i = 0; i < RealStationNum; ++i)
                {
                    Stations[i].SetAllParaNull();
                    Items[i].Description = "dfsdf！";
                    Items[i].StationStatus = StationStatusEnum.Unkown;
                }
            }

            //MessagingCenter.Send(this, Utils.MessengerKeys.RenewData, 1);

        }

        void ChangeItemInfo(Item item, Station station)
        {
            if (station.IsError == false)
            {
                if (station.IsNormal == true)
                    item.StationStatus = StationStatusEnum.Running;
                else
                    item.StationStatus = StationStatusEnum.Warning;
            }               
            else
                item.StationStatus = StationStatusEnum.Error;
            item.Description = "通信正常!";
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
                IsLoadMoreIng = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load items.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }

        static bool loadIsbusy;
        async void LoadmoreItem()
        {

            if (loadIsbusy == true)
                return;
            loadIsbusy = true;
            //var page = Apphelper.HomeTabPage;
            await Task.Delay(100);
            await Task.Delay(1200);
            if (RealItemsCount >= 29)
            {
                IsLoadMoreIng = false;
                loadIsbusy = false;
                return;
            }
            else
                IsLoadMoreIng = true;
            AddNewItem(new Item
            {
                StationName = "新站1",
                StationStatus = StationStatusEnum.Warning,
                Description = "报警当中."
            });
            AddNewItem(new Item
            {
                StationName = "新站2",
                StationStatus = StationStatusEnum.Warning,
                Description = "报警当中.."
            });
            AddNewItem(new Item
            {
                StationName = "新站3",
                StationStatus = StationStatusEnum.Warning,
                Description = "报警当中..."
            });
            loadIsbusy = false;
        }

        public void AddNewItem(Item item)
        {
            Items.Insert(Items.Count - 1, item);
        }

        public int RealItemsCount
        {
            get { return Items.Count - 1; }
        }

        public bool IsLoadMoreIng
        {
            set
            {
                Items.LastOrDefault().IsLoadMore = value;
            }
        }
        static bool itemTapBusy;
        async void OnSelectItem(Item item)
        {
            if (item == null)
                return;
            if (item == Items.LastOrDefault())
                return;
            if (itemTapBusy == true)
                return;
            itemTapBusy = true;

            int index;
            try
            {
                index = int.Parse(item.Id);
            }
            catch 
            {
                itemTapBusy = false;
                return;
            }
            Apphelper.HomeTabPage.RepportViewModel.Items.Add(string.Format("您在{0}查看了{1}",
                DateTime.Now, item.StationName));
            Apphelper.HomeTabPage.RepportView.RefreshData();
            var itemViewModel = new StationDetailViewModel(Stations[index].Name,index);
            await Apphelper.HomeTabPage.Navigation.PushAsync(new Pages.StationDetailPage(itemViewModel));
            itemTapBusy = false;
        }

        int RealStationNum = 20;
        async void OnChangeItem(Item item)
        {
            if (item == Items.Last() || Items.IndexOf(item) < RealStationNum)
            {
                int index = 0;
                try
                {
                    index = int.Parse(item.Id);
                }
                catch
                {

                }

                await Apphelper.HomeTabPage.Navigation.PushAsync(new Pages.StationSettingPage(
                    new StationSettingViewModel($"{Stations[index].Name}-修改参数可见性",
                        new Sqlite.Models.StationFixPara())));
            }          
        }

        async void OnDeleteItem(Item item)
        {
            if (item == Items.Last() || Items.IndexOf(item) < RealStationNum)
            {
                int index;
                try
                {
                    index = int.Parse(item.Id);
                }
                catch
                {

                }
                await Apphelper.HomeTabPage.DisplayAlert("不能删除的系统元素", "消息", "知道了");
                return;
            }
            Items.Remove(item);
        }

        public override void SaveState(IDictionary<string, object> dictionary)
        {
            string strSave = "";
            foreach (Station station in Stations)
            {
                var str = station.一网.IsVisible.ToString() + "|" +
                    station.二网高区.IsVisible.ToString() + "|" +
                    station.二网中区.IsVisible.ToString() + "|" +
                    station.二网低区.IsVisible.ToString() + "|" +
                    station.水箱.IsVisible.ToString() + "|" +
                    station.水箱2.IsVisible.ToString() + "|" +
                    station.水箱进水阀.IsVisible.ToString() + "|" +
                    station.总调节阀.IsVisible.ToString() + "|" +
                    station.泵系列[0].IsVisible.ToString() + "|" +
                    station.泵系列[1].IsVisible.ToString() + "|" +
                    station.泵系列[2].IsVisible.ToString() + "|" +
                    station.泵系列[3].IsVisible.ToString() + "|" +
                    station.泵系列[4].IsVisible.ToString() + "|" +
                    station.泵系列[5].IsVisible.ToString() + "|" +
                    station.泵系列[6].IsVisible.ToString() + "|" +
                    station.泵系列[7].IsVisible.ToString() + "|" +
                    station.泵系列[8].IsVisible.ToString() + "|" +
                    station.泵系列[9].IsVisible.ToString() + "|" + "&";
                strSave += str;
            }
            dictionary[Utils.SaveKeys.StationsVisible] = strSave;
        }

        public override void RestoreState(IDictionary<string, object> dictionary)
        {
            if (dictionary.ContainsKey(Utils.SaveKeys.StationsVisible) == false)
                return;
            var strSave = (string)dictionary[Utils.SaveKeys.StationsVisible];
            var strStations = strSave.Split('&');
            for(int i = 0;i<strStations.Length - 1 ;++i)
            {
                var strParas = strStations[i].Split('|');
                Stations[i].一网.IsVisible = bool.Parse(strParas[0]);
                Stations[i].二网高区.IsVisible = bool.Parse(strParas[1]);
                Stations[i].二网中区.IsVisible = bool.Parse(strParas[2]);
                Stations[i].二网低区.IsVisible = bool.Parse(strParas[3]);
                Stations[i].水箱.IsVisible = bool.Parse(strParas[4]);
                Stations[i].水箱2.IsVisible = bool.Parse(strParas[5]);
                Stations[i].水箱进水阀.IsVisible = bool.Parse(strParas[6]);
                Stations[i].总调节阀.IsVisible = bool.Parse(strParas[7]);
                Stations[i].泵系列[0].IsVisible = bool.Parse(strParas[8]);
                Stations[i].泵系列[1].IsVisible = bool.Parse(strParas[9]);
                Stations[i].泵系列[2].IsVisible = bool.Parse(strParas[10]);
                Stations[i].泵系列[3].IsVisible = bool.Parse(strParas[11]);
                Stations[i].泵系列[4].IsVisible = bool.Parse(strParas[12]);
                Stations[i].泵系列[5].IsVisible = bool.Parse(strParas[13]);
                Stations[i].泵系列[6].IsVisible = bool.Parse(strParas[14]);
                Stations[i].泵系列[7].IsVisible = bool.Parse(strParas[15]);
                Stations[i].泵系列[8].IsVisible = bool.Parse(strParas[16]);
                Stations[i].泵系列[9].IsVisible = bool.Parse(strParas[17]);
            }
        }

    }
}
