using System.Collections.Generic;

namespace AppLabo5.Model
{
    public class Forecast
    {
        public string Cityname { get; set; }

        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }
    }
}