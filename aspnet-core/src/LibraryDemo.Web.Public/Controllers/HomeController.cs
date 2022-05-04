using Microsoft.AspNetCore.Mvc;
using LibraryDemo.Web.Controllers;

namespace LibraryDemo.Web.Public.Controllers
{
    public class HomeController : LibraryDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}