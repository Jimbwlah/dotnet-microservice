using System.Web.Mvc;
using System.Web.Routing;

namespace BS_Microservice
{
    /// <summary>
    /// Route configuration class
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Route registration
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Prevent requests for the web resource files such as WebResource.axd or ScriptResource.axd from being passed to a controller.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Default route for all controller actions
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}