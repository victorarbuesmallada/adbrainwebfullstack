using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Routing;

namespace DefaultConfiguration.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Formatters
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.Add(new FormUrlEncodedMediaTypeFormatter());

            // Web API routes
            config.Routes.MapHttpRoute(
                "RedditItemsExposure",
                "sports",
                new { controller= "Items", action = "GetSportsByDomainGroupByAuthor" }, 
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Get, HttpMethod.Options) }
            );
        }
    }
}
