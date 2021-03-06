﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Charlatan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "sitemap.xml",
                url: "sitemap.xml",
                defaults: new { controller = "Site", action = "SitemapXml" },
                namespaces: new[] { "Auction.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Details",
                url: "Details/{name}",
                defaults: new { controller = "Details", action = "Index", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
