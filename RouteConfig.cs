using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CMS.Web.Infrastracture;

namespace CMS.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // BotDetect requests must not be routed
            routes.IgnoreRoute("{*botdetect}", new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });
            //routes.MapRoute(
            //    name: "lang",
            //    url: "",
            //    defaults: new { controller = "Home", action = "lang", id = UrlParameter.Optional },
            //    namespaces: new[] { "CMS.Web.Controllers" }
            //);

            routes.MapRoute(
               name: "install",
               url: "install/{action}",
               defaults: new { controller = "Install", action = "index" },
               namespaces: new[] { "CMS.Web.Controllers" }
           );

            routes.Add(new CustomPagesRoute());

            routes.MapRoute(
               name: "NewsRoute",
               url: "{lang}/news-{url}",
               defaults: new { controller = "News", action = "GetDetailsNews" },
               namespaces: new[] { "CMS.Web.Controllers" },
               constraints: new { lang = @"\w{2}" }
           );


            routes.MapRoute(
                name: "ArticleRoute",
                url: "{lang}/Article-{url}",
                defaults: new { controller = "Article", action = "GetDetails" },
                namespaces: new[] { "CMS.Web.Controllers" },
                constraints: new { lang = @"\w{2}" }
            );
           
            routes.MapRoute(
            name: "link_Counter",
            url: "{lang}/e/{id}",
            defaults: new { controller = "Links", action = "Link" },
            namespaces: new[] { "CMS.Web.Controllers" },
              constraints: new { lang = @"\w{2}" }
            );

            routes.MapRoute(
    name: "link_Counter_lang",
    url: "{lang}/e/{id}",
    defaults: new { controller = "Links", action = "Link" },
    namespaces: new[] { "CMS.Web.Controllers" }, constraints: new { lang = @"\w{2}" });

         
            routes.MapRoute(
               name: "WithLanguageRoute",
               url: "{lang}/{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, lang = "" },
               namespaces: new[] { "CMS.Web.Controllers" },
               constraints: new { lang = @"\w{2}" }
           );

          

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "CMS.Web.Controllers" }
            );

            routes.MapRoute(
                name: "GEtOnlinePayment",
                url: "{lang}/User/OnlinePayment-{invoiceNumber}",
                defaults: new { controller = "Factor", action = "GetOnlinePayment" },
                namespaces: new[] { "CMS.Web.Areas.Users.Controllers" },
                constraints: new { lang = @"\w{2}" }
            );

            // routes.MapRoute(
            //   name: "APIDefault",
            //   url: "{controller}/{action}/{id}",
            //   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //   namespaces: new[] { "CMS.Web.API" }

            //);



            //            routes.MapRoute(
            //name: "Default_title",
            //url: "{controller}/{action}/{id}/{title}",
            //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, title = "" },
            //namespaces: new[] { "CMS.Web.Controllers" }

            //);

            //            routes.MapRoute(
            //name: "Default_title_lang",
            //url: "{lang}/{controller}/{action}/{id}/{title}",
            //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, title = "" },
            //namespaces: new[] { "CMS.Web.Controllers" }

            //);




        }
    }
}
