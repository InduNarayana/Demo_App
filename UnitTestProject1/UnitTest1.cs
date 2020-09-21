using DemoApp.Controllers;
using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new WeatherForecastController(new Logger<WeatherForecastController>(new LoggerFactory()));
            var request = new ForecastRequest
            {
                Latitude = 65,
                Longitude = 34
            };
            var response = controller.GetTemperatureByLocation(request) as ContentResult;

            Assert.AreEqual(200, response.StatusCode);
        }
    }
}
