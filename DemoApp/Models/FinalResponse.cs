using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class FinalResponse
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("employeeId")]
        public int EmployeeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("initial")]
        public string Initial { get; set; }
    }
}
