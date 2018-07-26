
using Xamarin.Forms;

using SmartHeatStation.Pages;
using SmartHeatStation.Sqlite;

namespace SmartHeatStation
{
    public partial class App : Application
    {
        private readonly string DatabaseName = "StationData.sqlite";
        public static Database Database { get; set; }

        public App()
        {
            InitializeComponent();

            DatabaseOperation();
            if (Helper.PropertiesHelper.Get<bool>(RegisterPage.SaveKeyIsRegister) == true)
                MainPage = new HomePage();
            else
                MainPage = new RegisterPage();

        }

        private void DatabaseOperation()
        {
            Database = new Database(DatabaseName);     
        }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {
            if (Current.MainPage is HomePage)
            {
                var homepage = Current.MainPage as HomePage;
                homepage.OnSleep();
            }
            else if(Current.MainPage is RegisterPage)
            {
                var homepage = MainPage.Navigation.ModalStack[0] as HomePage;
                homepage.OnSleep();
            }
        }

        protected override void OnResume()
        { 

        }
    }
}
