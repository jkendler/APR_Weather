using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public class WeatherService : IWeatherService
    {

        public async Task<WeatherItem> CurrentWeatherAsync()
        {
            WeatherItem bericht1 = new WeatherItem();
            bericht1.Beschreibung = "Es ist sehr son­nig. Das Wet­ter er­laubt eine groß­ar­ti­ge Fern­sicht.";
            

            WeatherItem bericht2 = new WeatherItem();
            bericht2.Beschreibung = "Es regnet zurzeit stark...";

            WeatherItem bericht3 = new WeatherItem();
            bericht3.Beschreibung = "Es schneit...";

            

            List<WeatherItem> weatherlist = new List<WeatherItem>();
            weatherlist.Add(bericht1);
            weatherlist.Add(bericht2);
            weatherlist.Add(bericht3);


            Random r = new Random();
            int randomzahl = r.Next(weatherlist.Count); 

            await Task.Delay(2000); 

            return weatherlist[randomzahl];


        }


    }
}
