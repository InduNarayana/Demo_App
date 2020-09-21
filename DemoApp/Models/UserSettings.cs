

namespace DemoApp.Models
{
    public class UserSettings
    {
        /// <summary>
        /// Api Details 
        /// </summary>
        public ApiDetails RestApi { get; set; }
    }

    /// <summary>
    /// Api Details Class
    /// </summary>
    public class ApiDetails
    {
        /// <summary>
        /// Endpoint url
        /// </summary>
        public string Url { get; set; }
    }
}
