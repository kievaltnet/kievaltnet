using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KievAltNet
{	
	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.MapRoute(
				"Default",                                              // Route name
				"{controller}/{action}/{id}",                           // URL with parameters
				new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterRoutes(RouteTable.Routes);
		}
	}
}