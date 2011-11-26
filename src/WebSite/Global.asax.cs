using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSite.App.Speakers;

namespace WebSite
{
    public class KievAltNetApp : System.Web.HttpApplication
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
                "Default", // Route name
                "{controller}/", // URL with parameters
                new { controller = "Home", action = "Index" } // Parameter defaults
            );

            routes.MapRoute(
                "Details", // Route name
                "{controller}/{id}/", // URL with parameters
                new { controller = "Home", action = "Details" } // Parameter defaults
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