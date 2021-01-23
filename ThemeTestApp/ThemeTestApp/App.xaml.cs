using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemeTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Current.RequestedThemeChanged += Current_RequestedThemeChanged;
        }

        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("App Alert", App.Current.UserAppTheme.ToString(), "ok");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
