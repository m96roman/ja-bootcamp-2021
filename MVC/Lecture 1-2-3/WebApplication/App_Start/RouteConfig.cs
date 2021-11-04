using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{file}.jpg");

            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            */

            routes.MapRoute(
                name: "ValueShowId",
                url: "value/{id}",
                defaults: new { controller = "Home", action = "Show", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ValueShow",
                url: "value/show/{id}",
                defaults: new { controller = "Home", action = "Show", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Value",
                url: "value",
                defaults: new { controller = "Home", action = "Show" }
            );

            //users task
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
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
