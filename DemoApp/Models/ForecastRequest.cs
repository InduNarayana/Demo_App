using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class ForecastRequest
    {
        [Required]
        [Range(-90, 90)]
        [JsonProperty("Latitude")]
        public int? Latitude { get; set; }

        [Required]
        [Range(-180, 180)]
        [JsonProperty("Longitude")]
        public int? Longitude { get; set; }

    }
}
