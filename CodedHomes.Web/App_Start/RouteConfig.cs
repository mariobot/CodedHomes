﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodedHomes.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
	  routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

	  routes.MapRoute(
	      "Default",                                              // Route name
	      "{controller}/{action}/{id}",                           // URL with parameters
	      new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
	  );

	  //routes.MapRoute(
	  //    name: "Default",
	  //    url: "{controller}/{action}/{id}",
	  //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
	  //);	  
        }

        protected void Application_Start()
        {
	  RegisterRoutes(RouteTable.Routes);
        }
    }
}