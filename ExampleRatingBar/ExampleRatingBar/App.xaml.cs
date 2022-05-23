using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace ExampleRatingBar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.On<Windows>().SetImageDirectory("Assets");
            MainPage = new MainPage();
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
