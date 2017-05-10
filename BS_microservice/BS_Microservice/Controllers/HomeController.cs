namespace BS_Microservice.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// The home controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The index action
        /// </summary>
        /// <returns>Returns the home page</returns>
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
