using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Controls
{
    public partial class ListViewLoadMoreFooter : ContentView
    {
        public ListViewLoadMoreFooter()
        {
            InitializeComponent();
        }

        #region IsLoadMore

        public static readonly BindableProperty IsLoadMoreProperty =
            BindableProperty.Create("IsLoadMore",
                typeof(bool),
                typeof(ListViewLoadMoreFooter),
                true,
                propertyChanged: IsLoadMorePropertyChanged);

        private static void IsLoadMorePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (ListViewLoadMoreFooter)bindable;
            var result = (bool)newValue;
            if(result == true)
            {
                tab.progressCircleBar.IsVisible = true;
                tab.progressCircleBar.IsRunning = true;
                tab.label.Text = "正在加载...";
            }
            else
            {
                tab.progressCircleBar.IsVisible = false;
                tab.label.Text = "已加载全部";
            }

        }
        public bool IsLoadMore
        {
            get { return (bool)GetValue(IsLoadMoreProperty); }
            set
            {
                SetValue(IsLoadMoreProperty, value);
            }
        }
        #endregion

    }
}
