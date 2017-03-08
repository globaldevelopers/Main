using System.Web.Mvc;

namespace GlobalDevelopers.WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}