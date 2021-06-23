using System;
using Weather.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TinyIoC.TinyIoCContainer.Current.Register<IWeatherService>(new WeatherService());

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
