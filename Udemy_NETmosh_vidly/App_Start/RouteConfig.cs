﻿
using System.Web.Mvc;
using System.Web.Routing;

namespace Udemy_NETmosh_vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapMvcAttributeRoutes();

            //Voorbeeld Maprouting van eerdere versies .NET
            /*routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action ="MoviesByReleaseDate" },
                new {year = @"\d{4}", month = @"\d{2}" });
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
