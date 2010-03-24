using System.Web.Mvc;

namespace KievAltNet.Controllers
{
	[HandleError]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{			
			return View();
		}		

		public ActionResult About()
		{
			return View();
		}

		//protected override ViewResult View(string viewName, string masterName, object model)
		//{
		//    // Detect language and render
		//    var lang = "Ru";
		//    return base.View(viewName + lang, masterName, model);
		//}
	}
}
