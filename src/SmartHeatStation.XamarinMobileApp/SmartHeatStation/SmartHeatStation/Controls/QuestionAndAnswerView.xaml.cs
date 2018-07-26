using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Controls
{
    public partial class QuestionAndAnswerView : ContentView
    {
        public QuestionAndAnswerView()
        {
            InitializeComponent();
        }

        #region TextQuestion
        public static readonly BindableProperty TextQuestionProperty =
            BindableProperty.Create("TextQuestion",
        typeof(string),
        typeof(QuestionAndAnswerView),
        "Q:智慧换热站的...",
        propertyChanged: TextQuestionPropertyChanged);

        private static void TextQuestionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (QuestionAndAnswerView)bindable;
            tab.labelQuestion.Text = "Q:" + (string)newValue;
        }

        public string TextQuestion
        {
            get { return (string)GetValue(TextQuestionProperty); }
            set
            {
                SetValue(TextQuestionProperty, value);
            }
        }
        #endregion

        #region TextAnswer
        public static readonly BindableProperty TextAnswerProperty =
            BindableProperty.Create("TextAnswer",
        typeof(string),
        typeof(QuestionAndAnswerView),
        "A:这个那个这个那个...",
        propertyChanged: TextAnswerPropertyChanged);

        private static void TextAnswerPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (QuestionAndAnswerView)bindable;
            tab.labelAnswer.Text = "A:" + (string)newValue;
        }

        public string TextAnswer
        {
            get { return (string)GetValue(TextAnswerProperty); }
            set
            {
                SetValue(TextAnswerProperty, value);
            }
        }
        #endregion

    }
}
