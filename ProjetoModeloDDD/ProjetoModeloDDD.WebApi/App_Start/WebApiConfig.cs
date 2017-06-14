using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace ProjetoModeloDDD.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            // Web API configuration and services
            //var formatters = GlobalConfiguration.Configuration.Formatters;//rest, setando json como formato principal
            //var jsonFormatter = formatters.JsonFormatter;
            //var settings = jsonFormatter.SerializerSettings;//serializando formato json

            //jsonFormatter.SerializerSettings.PreserveReferencesHandling =
            //    Newtonsoft.Json.PreserveReferencesHandling.None;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);//removendo formato xml
            //settings.Formatting = Formatting.Indented;//indentando
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();//propriedades em minusculo
            //config.EnableCors();//Install-Package Microsoft.AspNet.WebApi.Cors

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
