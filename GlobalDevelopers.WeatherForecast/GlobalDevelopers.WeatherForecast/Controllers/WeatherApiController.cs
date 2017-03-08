using System.Collections.Generic;
using System.Web.Http;
using GlobalDevelopers.WeatherForecast.Models;
using GlobalDevelopers.WeatherForecast.Services;

namespace GlobalDevelopers.WeatherForecast.Controllers
{
    public class WeatherApiController : ApiController
    {
        private readonly IWeatherService weatherService;

        public WeatherApiController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        // GET api/<controller>
        [Route("api/Weather")]
        [HttpGet]
        public IEnumerable<WeatherViewModel> Get()
        {
            var content = weatherService.GetWeatherData();

            var weatherData = new WeatherData(content);

            return weatherData.WeatherViewModelList;
        }
    }
}