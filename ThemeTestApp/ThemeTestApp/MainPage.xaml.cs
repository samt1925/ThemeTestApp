using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThemeTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            App.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
        }
        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("MainPage Alert", App.Current.UserAppTheme.ToString(), "ok");
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = OSAppTheme.Light;
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = OSAppTheme.Dark;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = OSAppTheme.Unspecified;
        }
    }
}
