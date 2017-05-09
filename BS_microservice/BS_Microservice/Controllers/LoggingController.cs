using System.Web.Http;
using System.Web.Http.Results;
using BS_Api.Services;
using BS_Models.API;

namespace BS_Microservice.Controllers
{
    /// <summary>
    /// The logging controller
    /// </summary>
    public class LoggingController : ApiController
    {
        /// <summary>
        /// The <see cref="ILoggingService"/>.
        /// </summary>
        private readonly ILoggingService _loggingService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestLoggingService"/> class.
        /// </summary>
        /// <param name="loggingService">The <see cref="ILoggingService"/>.</param>
        public LoggingController(ILoggingService loggingService)
        {
            this._loggingService = loggingService;
        }

        /// <summary>
        /// API method to write log messages from external services
        /// </summary>
        /// <returns></returns>
        [Route("logging/writelog")]
        [HttpPost]
        public JsonResult<LoggingResponse> WriteLogMessage(LoggingRequest loggingRequest)
        {
            return this.Json(this._loggingService.WriteLogMessage(loggingRequest));
        }
    }
}