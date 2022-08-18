using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ResumeWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "{controller}/{action}",
                defaults: new { controller = "Main", action = "Index" }
            );
            routes.MapRoute(
                name: "AboutMe",
                url: "{controller}/{action}",
                defaults: new { controller = "Main", action = "AboutM" }
            );
            routes.MapRoute(
                name: "Resume",
                url: "{controller}/{action}",
                defaults: new { controller = "Main", action = "Home"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Main", action = "Index" }
            );
        }
    }
}
