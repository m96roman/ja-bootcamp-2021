using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "ValueId",
                url: "value/{id}",
                defaults: new { controller = "Home", action = "Show", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ValueEdit",
                url: "value/{action}/{id}",
                defaults: new { controller = "Home", action = "Show", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Value",
                url: "value",
                defaults: new { controller = "Home", action = "Show" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
