using BS_Models.API;

namespace BS_Api.Services
{
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

            return response;
        }
    }
}
