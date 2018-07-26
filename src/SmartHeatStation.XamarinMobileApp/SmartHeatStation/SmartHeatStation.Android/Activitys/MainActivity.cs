

using Android.App;
using Android.Content.PM;
using Android.OS;

using Xamarin.Forms;
using FFImageLoading.Forms.Droid;
using SmartHeatStation.Droid.Sqlite;

namespace SmartHeatStation.Droid
{
    [Activity(Label = "智慧换热站", Icon = "@drawable/icon", Theme = "@style/MainTheme", 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
            
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            InitializeAssembly();
            FileAccessHelper.GetLocalFilePath("StationData.sqlite");
            LoadApplication(new App());

        }


        void InitializeAssembly()
        {
            //UserDialogs.Init(() => (Activity)Forms.Context);   
            DuGu.XFLib.Droid.Controls.Init();
            CachedImageRenderer.Init();
            AsNum.XFControls.Droid.AsNumAssemblyHelper.HoldAssembly();
        }

    }
}

