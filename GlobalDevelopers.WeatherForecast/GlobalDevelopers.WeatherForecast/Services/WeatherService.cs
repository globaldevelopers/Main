using System.Net;

namespace GlobalDevelopers.WeatherForecast.Services
{
    public class WeatherService : IWeatherService
    {
        public string GetWeatherData()
        {
            var url = "http://api.openweathermap.org/data/2.5/forecast/?q=London,gbr&units=metric&APPID=ea37e0ed896b17246d2c035325a0b1db";

            var client = new WebClient();

            var data = client.DownloadString(url);

            return data;
        }
    }
}