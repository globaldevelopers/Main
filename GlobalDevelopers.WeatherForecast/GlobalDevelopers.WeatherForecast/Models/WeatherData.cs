using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace GlobalDevelopers.WeatherForecast.Models
{
    public class WeatherData
    {
        public WeatherData(string json)
        {
            var jObject = JObject.Parse(json);

            var list = jObject["list"];

            WeatherViewModelList = new List<WeatherViewModel>();

            foreach (var item in list)
            {
                WeatherViewModelList.Add(new WeatherViewModel { ForecastDate = item["dt_txt"].ToString(), Temperature = (item["main"])["temp"].ToString() });
            }
        }
        public List<WeatherViewModel> WeatherViewModelList { get; }
    }
}