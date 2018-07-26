using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Views
{
    public partial class RepportView : ContentView
    {
        Pages.HomeDetailPage homePage => Parent.Parent.Parent as Pages.HomeDetailPage;

        string savekeyMessageList = "messageList";

        ViewModels.RepportViewViewModel viewModel;

        List<string> messageList;

        public RepportView(ViewModels.RepportViewViewModel pViewmodel)
        {
            InitializeComponent();
            viewModel = pViewmodel;
            messageList = new List<string>();
            this.BindingContext = viewModel;
            RestoreState(Application.Current.Properties);
        }

        static bool isBusy;

        public void RefreshData()
        {
            if (isBusy == true)
                return;

            messageList = viewModel?.Items.ToList();
            isBusy = true;
            if (messageList?.Count > 0)
            {
                foreach (var item in messageList)
                {
                    messageStack.Children.Add(new Label()
                    {
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                        FontAttributes = FontAttributes.Bold,
                        Text = item,
                        TextColor = Color.Black,
                    });
                }
                messageList.Clear();
                viewModel?.Items.Clear();
            }
            isBusy = false;
        }

        public void ClearData()
        {

             Label label = messageStack.Children[0] as Label;

             messageStack.Children.Clear();
             messageStack.Children.Add(label);
             messageList.Clear();
             viewModel?.Items.Clear();
             Helper.PropertiesHelper.Remove(savekeyMessageList);
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = "")
        {
            base.OnPropertyChanging(propertyName);
            RefreshData();
        }

        public void SaveState(IDictionary<string, object> dictionary)
        {
            string saveString = "";
            foreach (var item in messageStack.Children)
            {
                var lab = item as Label;
                saveString += lab.Text + "|";
            }
            dictionary[savekeyMessageList] = saveString;

        }

        public T GetDictionaryEntry<T>(IDictionary<string, object> dictionary,
            string key, T defaultValue)
        {
            if (dictionary.ContainsKey(key))
                return (T)dictionary[key];
            return defaultValue;
        }

        public void RestoreState(IDictionary<string, object> dictionary)
        {
            string[] saveStrings = GetDictionaryEntry(dictionary, savekeyMessageList, "test|").Split('|');
            for (int i = 1; i < saveStrings.Length - 1; ++i)
            {
                viewModel.Items?.Add(saveStrings[i]);
            }
            OnPropertyChanging();
        }
    }
}
