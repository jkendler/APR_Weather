using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public class WeatherItem : IWeatherItem
    {
        private string _beschreibung;
        public string Beschreibung
        {
            get { return _beschreibung; }
            set { _beschreibung = value; }
        }

    }
}
