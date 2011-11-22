using System.Web.Mvc;

namespace WebSite.Controllers.Home
{
    public class HomeController : Controller
    {                
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }
    }
}
