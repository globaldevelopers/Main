using System.Web.Mvc;
using ContactManager.DataAccess;

namespace ContactManager.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IContactProvider ContactProvider;

        public BaseController(IContactProvider contactProvider)
        {
            ContactProvider = contactProvider;
        }
    }
}