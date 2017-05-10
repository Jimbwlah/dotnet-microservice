namespace BS_Utilities.File
{
    using System;
    using System.IO;
    using System.Web;

    /// <summary>
    /// The text writer class
    /// </summary>
    public class TextWriter
    {
        /// <summary>
        /// Method to append text to a log file on the hard drive
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="message">The message</param>
        /// <param name="date">The date</param>
        /// <returns>A boolean indicating whether the text was written</returns>
        public static bool WriteText(string id, string message, DateTime date)
        {
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(message))
            {
                // Write to the root
                using (StreamWriter _outputFile = new StreamWriter(HttpContext.Current.Server.MapPath("~/Logging/API_Logging.txt"), true))
                {
                    _outputFile.WriteLine(string.Format("id: {0}, message: {1}, date: {2:G}", id, message, date));
                }

                return true;
            }

            return false;
        }
    }
}
