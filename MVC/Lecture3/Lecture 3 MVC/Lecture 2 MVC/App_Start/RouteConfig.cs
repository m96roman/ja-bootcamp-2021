using SimpleHTTPHanlder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lecture_2_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{file}.jpg");
            
            routes.MapRoute(
                 name: "SearchText",
                 url: "{controller}/{action}/{searchText}",
                 defaults: new { controller = "User", action = "FilterUsers", searchText = UrlParameter.Optional }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
        class CustomRouteHandler : IRouteHandler
        {
            public IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                return new ImageHandler();
            }
        }
    }
}
