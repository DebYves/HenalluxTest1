﻿using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Threading.Tasks;
using System.Linq;
using System.Text;
using AppLabo5.Model;
using Newtonsoft.Json.Linq;


namespace AppLabo5.DAO
{
    public class WeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast()
        {
            var wc = new HttpClient();
            var weather = await wc.GetStringAsync(
                new Uri(
                    "http://api.openweathermap.org/data/2.5/forecast/city?id=524901&APPID=50745565708a9c85fbe9d6cb37a27d50&lang=fr"));
            var rawWeather = JObject.Parse(weather);
            var forecast = rawWeather["list"].Children().Select(d => new WeatherForecast()
            {
                Date = d["dt_txt"].Value<DateTime>(),
                MinTemp = d["main"]["temp_min"].Value<double>(),
                MaxTemp = d["main"]["temp_max"].Value<double>(),
                WeatherDescription = d["weather"].First["description"].Value<string>(),
                WindSpeed = d["wind"]["speed"].Value<double>()
            });
            return forecast;
        }
    }
}