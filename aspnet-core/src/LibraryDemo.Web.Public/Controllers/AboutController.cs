using Microsoft.AspNetCore.Mvc;
using LibraryDemo.Web.Controllers;

namespace LibraryDemo.Web.Public.Controllers
{
    public class AboutController : LibraryDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}