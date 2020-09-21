
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class SampleRequest
    {
        [JsonProperty("title")]
        [Required]
        public string Title { get; set; }

        [Required]
        [JsonProperty("body")]
        public string Body { get; set; }

        [Required]
        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}
