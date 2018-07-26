using System.Threading.Tasks;
using SmartHeatStation.Models;
using SmartHeatStation.Pages;
using SmartHeatStation.Helper;
using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.ViewModels.MasterPageViewModel))]
namespace SmartHeatStation.ViewModels
{
    public class MasterPageViewModel : ListViewModelBase<ItemMenu> 
    {
        string[] menuItemName =
        {
            "更改账号",
            "异常汇总",
            "消息设置",
            "时间设置",
            "站点查询",
            "通信设置",
        };
        bool isAcceptMessage;
        public TimeSettingViewModel TimeViewModel;

        public MasterPageViewModel(string title) 
            : base(title)
        {
            ClearData = new Command(OnClearData);
            Logout = new Command(OnLogout);
            Items.Add(new ItemMenu() { Id = menuItemName[0], ImageSource = "menu_ic_user.png", Text = menuItemName[0]});
            Items.Add(new ItemMenu() { Id = menuItemName[1], ImageSource = "menu_ic_ranking.png", Text = menuItemName[1] });
            Items.Add(new ItemMenu() { Id = menuItemName[2], ImageSource = "menu_ic_card.png", Text = menuItemName[2] });
            Items.Add(new ItemMenu() { Id = menuItemName[3], ImageSource = "menu_ic_current_book.png", Text = menuItemName[3] });
            Items.Add(new ItemMenu() { Id = menuItemName[4], ImageSource = "menu_ic_new_ride.png", Text = menuItemName[4] });
            Items.Add(new ItemMenu() { Id = menuItemName[5], ImageSource = "menu_ic_chain.png", Text = menuItemName[5] });
            IsAcceptMessage = true;
            TimeViewModel = new TimeSettingViewModel();
        }

        public async override void OnSelectItem(ItemMenu item)
        {
            base.OnSelectItem(item);
            Apphelper.HomePage.IsPresented = false;
            await Task.Delay(250);  //等待Master页面收回
            switch(item.Id)
            {
                case "更改账号":
                    await Apphelper.Logout();
                    break;               
                case "异常汇总":
                    await Apphelper.HomeTabPage.Navigation.
                        PushAsync(new ExceptionPage(new ExceptionViewModel(item.Id)));
                    break;
                case "消息设置":
                    await Apphelper.HomeTabPage.Navigation.
                       PushAsync(new MessagaSettingPage());
                    break;
                case "时间设置":
                    await Apphelper.HomeTabPage.Navigation.
                        PushAsync(new TimeSettingPage(TimeViewModel));
                    break;
                case "站点查询":
                    await Apphelper.HomeTabPage.Navigation.
                      PushAsync(new StationSettingBeforePage(new StationSettingBeforeViewModel("选择站点")));
                    break;
                case "通信设置":
                    await Apphelper.HomeTabPage.Navigation.
                      PushAsync(new CommunacationSettingPage(new CommunacationPageViewModel()));
                    break;
            }
           
        }

        async void OnLogout(object obj)
        {
            await Apphelper.Logout();
        }

        async void OnClearData(object obj)
        {           
            var result =  await Apphelper.HomeTabPage.DisplayAlert("系统消息", "确定清空所有消息？", "确定","取消");
            if(result == true)
            {
                Apphelper.HomeTabPage.RepportView.ClearData();
                await Apphelper.HomeTabPage.DisplayAlert("消息","清除成功！","知道了");

            }
        }

        public Command ClearData { get; set; }
        public Command Logout { get; set; }

        public bool IsAcceptMessage
        {
            get { return isAcceptMessage; }
            set { SetProperty(ref isAcceptMessage, value); }
        }

    }
}
