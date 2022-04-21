using Microsoft.AspNetCore.Mvc;
using Acme.PhoneBookDemo.Web.Controllers;

namespace Acme.PhoneBookDemo.Web.Public.Controllers
{
    public class AboutController : PhoneBookDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}