using BS_Models.API;

namespace BS_Api.Services
{
    using BS_Utilities.File;

    /// <summary>
    /// The REST logger service
    /// </summary>
    public class RestLoggingService : ILoggingService
    {
        /// <summary>
        /// Writes a log message from external services
        /// </summary>
        /// <param name="loggingRequest">The loggin request</param>
        /// <returns>The <see cref="LoggingResponse"/>.</returns>
        public LoggingResponse WriteLogMessage(LoggingRequest loggingRequest)
        {
            var response = new LoggingResponse();

            if (TextWriter.WriteText(loggingRequest.Id, loggingRequest.Message, loggingRequest.Date))
            {
                response.ResponseMessage = "Message written to log";
            }
            else
            {
                response.ResponseMessage = "Message could not be written at this time";
            }

            return response;
        }
    }
}
