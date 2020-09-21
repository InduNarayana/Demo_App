using DemoApp.Models;
using DemoApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace DemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleApiController
    {
        private readonly ISampleRepository SampleRepository;
        public SampleApiController(ISampleRepository sampleRepository)
        {
            SampleRepository = sampleRepository;
        }
        [HttpPost("create")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ModelValidationFilter]
        public IActionResult CreateEmployee([FromBody] SampleRequest sampleRequest)
        {
            var response = SampleRepository.CreateEmployee(sampleRequest);
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(response),
                ContentType = "application/json",
                StatusCode = 200
            };
        }

        private IActionResult ContentResult(string v)
        {
            throw new NotImplementedException();
        }
    }
}
