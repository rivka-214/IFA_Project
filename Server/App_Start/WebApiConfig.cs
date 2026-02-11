using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Server.Filters;

namespace Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // CORS – חיבור ל-Angular
            var cors = new EnableCorsAttribute(
                origins: "http://localhost:4200",
                headers: "*",
                methods: "*"
            );
            config.EnableCors(cors);


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

             config.Formatters.Remove(config.Formatters.XmlFormatter);

            // camelCase ל-JSON (id / name)
            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();

            jsonFormatter.SerializerSettings.Formatting = Formatting.Indented;
            config.Filters.Add(new GlobalExceptionFilter());

        }
    }
}
