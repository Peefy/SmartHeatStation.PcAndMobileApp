using Android.Content;
using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.Droid.Services.FinishApplication))]

namespace SmartHeatStation.Droid.Services
{
    class FinishApplication : SmartHeatStation.ICloseContext
    {
        public void DoubleClickFinish()
        {
            Intent intent = new Intent(Intent.ActionMain);
            intent.SetFlags(ActivityFlags.NewTask);
            intent.AddCategory(Intent.CategoryHome);
            Forms.Context.StartActivity(intent);
        }
    }
}