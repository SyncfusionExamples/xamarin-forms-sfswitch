using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switch_GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SfSwitch_StateChanged(object sender, Syncfusion.XForms.Buttons.SwitchStateChangedEventArgs e)
        {
            string displayText;
            if ((bool)e.NewValue)
            {
                displayText = "On State";
            }
            else 
            {
               displayText= "Off State";
            }

            DisplayAlert("StateChanged", displayText, "OK");
        }
    }
}
