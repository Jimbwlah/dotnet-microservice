namespace BS_Models.API
{
    using System;
    using System.ComponentModel.DataAnnotations;  

    /// <summary>
    /// The logging request model
    /// </summary>
    public class LoggingRequest
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        [Required(ErrorMessage = "Please supply an Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date
        /// </summary>
        [Required(ErrorMessage = "Please supply a date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the log message
        /// </summary>
        [Required(ErrorMessage = "Please supply a message")]
        [StringLength(255, ErrorMessage = "Your message is too long")]
        public string Message { get; set; }
    }
}
