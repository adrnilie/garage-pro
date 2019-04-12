using System.Web.Http;
using System.Web.Http.Cors;

namespace GaragePro.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // CORS Attributes
            var corsAttribute = new EnableCorsAttribute("*", "*", "*");

            // Enable CORS
            config.EnableCors(corsAttribute);

            // Web API configuration and services
            config.Filters.Add(new AuthorizeAttribute());

            // JSON Return type
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

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
