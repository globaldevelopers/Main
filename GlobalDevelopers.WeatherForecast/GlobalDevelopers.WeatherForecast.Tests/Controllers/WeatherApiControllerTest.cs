using System.Linq;
using GlobalDevelopers.WeatherForecast.Controllers;
using GlobalDevelopers.WeatherForecast.Models;
using GlobalDevelopers.WeatherForecast.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GlobalDevelopers.WeatherForecast.Tests.Controllers
{
    [TestClass]
    public class WeatherApiControllerTest
    {

        [TestMethod]
        public void WeatherApi_Get_Should_Return_WeatherData()
        {
            const string data = "{\"cod\":\"200\",\"message\":0.1758,\"city\":{\"id\":\"2643743\",\"name\":\"London\",\"coord\":{\"lon\":-0.12721,\"lat\":51.5064},\"country\":\"United Kingdom\",\"population\":0},\"cnt\":41,\"list\":[{\"dt\":1485291600,\"main\":{\"temp\":270.21,\"temp_min\":269.59,\"temp_max\":270.21,\"pressure\":1034.62,\"sea_level\":1042.75,\"grnd_level\":1034.62,\"humidity\":78,\"temp_kf\":0.62},\"weather\":[{\"id\":803,\"main\":\"Clouds\",\"description\":\"broken clouds\",\"icon\":\"04n\"}],\"clouds\":{\"all\":68},\"wind\":{\"speed\":1.62,\"deg\":159.502},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2017 - 01 - 24 21:00:00\"}]}";

            var mockWeatherService = new Mock<IWeatherService>();
            mockWeatherService.Setup(a => a.GetWeatherData()).Returns(data);

            var weatherApiController = new WeatherApiController(mockWeatherService.Object);

            var expectedData = new WeatherViewModel {ForecastDate = "2017 - 01 - 24 21:00:00", Temperature = "270.21"};
            
            var actualData = weatherApiController.Get().FirstOrDefault();

            Assert.IsNotNull(actualData);
            Assert.IsTrue(expectedData.Temperature.Equals(actualData.Temperature));
            Assert.IsTrue(expectedData.Temperature.Equals(actualData.Temperature));
        }

    }
}
