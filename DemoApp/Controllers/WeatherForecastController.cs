using System;
using System.Collections.Generic;
using System.Linq;
using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("location")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ModelValidationFilter]
        public IActionResult GetTemperatureByLocation([FromBody] ForecastRequest ForecastRequest)
        {
            var response = new Dictionary<string, string>
            {
                {"Temperature", "78" }
            };

            return new ContentResult
            {
                StatusCode = 200,
                Content = JsonConvert.SerializeObject(response),
                ContentType = "application/json"
            };
        }
    }
}
