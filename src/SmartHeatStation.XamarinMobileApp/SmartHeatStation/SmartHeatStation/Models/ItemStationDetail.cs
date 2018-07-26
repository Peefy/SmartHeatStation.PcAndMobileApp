
using Xamarin.Forms;

namespace SmartHeatStation.Models
{
    public class ItemStationDetail : BaseDataObject
    {
        string paraName = string.Empty;
        public string ParaName
        {
            get { return paraName; }
            set { SetProperty(ref paraName, value); }
        }

        string paraValue = string.Empty;
        public string ParaValue
        {
            get { return paraValue; }
            set { SetProperty(ref paraValue, value); }
        }

        Color textColor = Color.FromHex("#1976D2");
        public Color TextColor
        {
            get { return textColor; }
            set { SetProperty(ref textColor, value); }
        }

    }
}
