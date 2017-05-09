using System.Web.Http;
using System.Web.Http.Results;
using BS_Api.Services;
using BS_Models.API;

namespace BS_Microservice.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

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
            if (ModelState.IsValid)
            {
                return this.Json(this._loggingService.WriteLogMessage(loggingRequest));
            }
            else
            {
                // Format the error
                string errorMessage = string.Empty;
                string errorTitle = "Sorry, there was an error";

                // Find any errors and add to response
                if (ModelState.Values.Any())
                {
                    foreach (var value in ModelState.Values)
                    {
                        if (value.Errors.Any())
                        {
                            var firstOrDefault = value.Errors.FirstOrDefault();
                            if (firstOrDefault != null)
                            {
                                if (!string.IsNullOrEmpty(firstOrDefault.ErrorMessage))
                                {
                                    errorMessage += string.Format("{0}", firstOrDefault.ErrorMessage);
                                }
                                else if (firstOrDefault.Exception != null)
                                {
                                    errorMessage += string.Format("{0}", firstOrDefault.Exception.Message);
                                }
                            }
                        }
                    }
                }

                return this.Json(new LoggingResponse {ResponseMessage = string.Format("{0} - {1}", errorTitle, errorMessage)});
            }
        }
    }
}