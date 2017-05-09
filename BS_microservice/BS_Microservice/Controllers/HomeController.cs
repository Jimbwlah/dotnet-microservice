using System.Web.Mvc;

namespace BS_Microservice.Controllers
{
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
            return View();
        }
    }
}
