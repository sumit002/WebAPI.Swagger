using System.Web.Http;

namespace WebAPI.Swagger
{
    /// <summary>
    /// WebApi Config
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register Config
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

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
