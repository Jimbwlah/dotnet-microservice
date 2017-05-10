namespace BS_Microservice
{
    using System.Web.Http;
    using System.Web.Optimization;
    using System.Web.Routing;

    /// <summary>
    /// Global startup class
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// IIS application start functionality
        /// </summary>
        protected void Application_Start()
        {
            // Pass a delegate to the Configure method.
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Disable WebAPI 1
            //// WebApiConfig.Register(GlobalConfiguration.Configuration);

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}