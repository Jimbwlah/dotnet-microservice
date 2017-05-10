namespace BS_Api.Services
{
    using BS_Models.API;

    /// <summary>
    /// The logger service
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// Writes a log message from external services
        /// </summary>
        /// <param name="loggingRequest">The logging request</param>
        /// <returns>The <see cref="LoggingResponse"/>.</returns>
        LoggingResponse WriteLogMessage(LoggingRequest loggingRequest);
    }
}
