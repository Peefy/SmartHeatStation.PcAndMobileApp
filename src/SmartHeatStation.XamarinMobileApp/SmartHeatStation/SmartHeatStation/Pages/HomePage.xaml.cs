using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SmartHeatStation.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {

        public HomeDetailPage HomeTabPage => DetailPage;
        public HomeMasterPage HomeMenupage => masterPage;

        HomeMasterPage masterPage;

        public HomePage()
        {
            InitializeComponent();
            var viewModel = new ViewModels.MasterPageViewModel("大连金州智慧换热站");
            masterPage = new HomeMasterPage(viewModel);
            Master = masterPage;
        }

        public void OnSleep()
        {
            HomeTabPage?.RepportView.SaveState(Application.Current.Properties);
            HomeTabPage?.HomeViewModel.SaveState(Application.Current.Properties);
        }

    }

}
