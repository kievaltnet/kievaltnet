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
	}
}
