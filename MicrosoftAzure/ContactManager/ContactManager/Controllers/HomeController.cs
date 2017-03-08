using System;
using System.Globalization;
using System.Web.Mvc;
using ContactManager.DataAccess;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ContactProvider contactProvider = new ContactProvider();

            return View(contactProvider.GetContacts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}