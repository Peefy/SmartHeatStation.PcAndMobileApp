using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Controls
{
    public partial class SettingChildrenView : ContentView
    {
        public delegate void VoidDelegate(string stationname);
        public VoidDelegate TapEvent { get; set; }

        public SettingChildrenView()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var button = (Frame)sender;
            Color color = Color.Default;
            button.BackgroundColor = Color.FromHex("00B0F0").WithLuminosity(0.75);
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                button.BackgroundColor = color;
                return false;
            });
            TapEvent?.Invoke("");
        }

        #region ImageSource
        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create("ImageSource",
        typeof(string),
        typeof(SettingChildrenView),
        "tab2_off.png",
        propertyChanged: ImageSourcePropertyChanged);

        private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (SettingChildrenView)bindable;
            tab.image.Source = (string)newValue;

        }

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }
        #endregion

        #region LabelText
        public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create("LabelText",
        typeof(string),
        typeof(SettingChildrenView),
        "设置",
        propertyChanged: LabelTextPropertyChanged);

        private static void LabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (SettingChildrenView)bindable;
            tab.label.Text = (string)newValue;

        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set
            {
                SetValue(LabelTextProperty, value);
            }
        }
        #endregion
    }
}
