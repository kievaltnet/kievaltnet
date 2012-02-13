using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSite.App.Speakers;

namespace WebSite
{
    public class KievAltNetApp : HttpApplication
    {
        private static readonly Lazy<SpeakerProvider> _lazyProvider 
            = new Lazy<SpeakerProvider>(() => 
            {
                var speakersFolder = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/App/Speakers/Data/"));
                return new SpeakerProvider(speakersFolder);
            }, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
        public static SpeakerProvider Speakers { get { return _lazyProvider.Value; } }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            routes.MapRoute(
                "Speakers",
                "Speakers/{id}/",
                new { controller = "Speakers", action = "Details" }
            );

            routes.MapRoute(
                "Home",
                "",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}/",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            
        }
    }
}