using SmartHeatStation.Helper;
using SmartHeatStation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Views
{
    public partial class MineView : ContentView
    {
        ViewModels.MineViewViewModel viewModel;
        public MineView(ViewModels.MineViewViewModel pViewmodel)
        {
            InitializeComponent();
            viewModel = pViewmodel;
            this.BindingContext = viewModel;

            aboutChildrenView.TapEvent += delegate
            {
                viewModel.About.Execute(null);
            };


            helpChildrenView.TapEvent += delegate
            {
                viewModel.Help.Execute(null);
            };

        }

    }
}
