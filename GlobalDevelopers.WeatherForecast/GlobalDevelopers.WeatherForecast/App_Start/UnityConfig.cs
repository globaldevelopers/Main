using System.Web.Http;
using System.Web.Mvc;
using GlobalDevelopers.WeatherForecast.Services;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace GlobalDevelopers.WeatherForecast
{
    public static class UnityConfig
    {
        public static IUnityContainer Container { get; private set; }

        public static void RegisterComponents()
        {
            Container = new UnityContainer();
           
            Container.RegisterType<IWeatherService, WeatherService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(Container);
        }
    }
}