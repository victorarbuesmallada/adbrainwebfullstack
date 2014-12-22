using DefaultConfiguration.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            UnityWebApiActivator.Start();
            AutomapperConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register); 
            GlobalConfiguration.Configuration.Formatters.JsonFormatter
                .SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        protected void Application_End()
        {
            UnityWebApiActivator.Shutdown();
        }

    }
}
