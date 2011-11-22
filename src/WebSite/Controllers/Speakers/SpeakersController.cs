using System.Linq;
using System.Web.Mvc;

namespace WebSite.Controllers.Speakers
{
    public class SpeakersController : Controller
    {
        public ActionResult Index()
        {
            return View(new SpeakersIndex
            {
                Speakers = KievAltNetApp.Speakers.ToList()
            });
        }

        public ActionResult Details(string id)
        {
            return View(new SpeakerDetails
            {
                Speaker = KievAltNetApp.Speakers.Get(id)
            });
        }
    }
}
