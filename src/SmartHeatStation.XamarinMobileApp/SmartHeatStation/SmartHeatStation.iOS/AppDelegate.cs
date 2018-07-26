
using Foundation;
using UIKit;
using FFImageLoading.Forms.Touch;
using SmartHeatStation.iOS.Renderers;
using SmartHeatStation.iOS.Sqlite;

namespace SmartHeatStation.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {

            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.BlackOpaque, false);
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
            {
                TextColor = UIColor.Blue
            });

            global::Xamarin.Forms.Forms.Init();
            InitializeAssembly();
            FileAccessHelper.GetLocalFilePath("StationData.sqlite");
            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }

        void InitializeAssembly()
        {
            KeyboardOverlapRenderer.Init();
            CachedImageRenderer.Init();
            AsNum.XFControls.iOS.AsNumAssemblyHelper.HoldAssembly();
            DuGu.XFLib.iOS.Controls.Init();
            //Acr.UserDialogs.UserDialogs.Init();
        }

    }
}
