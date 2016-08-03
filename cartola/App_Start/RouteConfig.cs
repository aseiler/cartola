using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cartola
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

                routes.MapRoute(
                name: "Listar",
                url: "times/listar/{slug}",
                defaults: new { controller = "Times", action = "Listar", slug = UrlParameter.Optional });

                routes.MapRoute(
                    name: "Excluir",
                    url: "times/excluir/{slug}",
                    defaults: new { controller = "Times", action = "Excluir", slug = UrlParameter.Optional });

                routes.MapRoute(
                name: "Times",
                url: "Times",
                defaults: new { controller = "Times", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
