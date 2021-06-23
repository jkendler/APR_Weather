using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Weather.Services;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        IWeatherService WeatherService { get; set; }

        public MainPageViewModel()
        {
            this.WeatherService = TinyIoC.TinyIoCContainer.Current.Resolve<IWeatherService>();
            
        }


        private string _ausgabeText;

        public string AusgabeText
        {
            get { return _ausgabeText; }
            set { SetProperty(ref _ausgabeText, value); }
        }
       

        private Command _ausgabeCommand = null;

        public Command AusgabeCommand
        {
            get
            {
                return _ausgabeCommand ?? (_ausgabeCommand = new Command(GenerateText));
            }
        }


        public async void GenerateText()
        {
            WeatherItem weatheritem = new WeatherItem();
            weatheritem = await this.WeatherService.CurrentWeatherAsync();
            this.AusgabeText = weatheritem.Beschreibung;

        }


    }
}
