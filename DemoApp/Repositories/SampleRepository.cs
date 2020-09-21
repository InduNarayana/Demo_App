using AutoMapper;
using DemoApp.Models;
using DemoApp.Repositories.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;

namespace DemoApp.Repositories
{
    public class SampleRepository: ISampleRepository
    {
        private readonly IHttpClientFactory HttpClientFactory;
        private readonly IOptions<UserSettings> Config;
        public IMapper Mapper { get; }

        public SampleRepository(IHttpClientFactory httpClientFactory, IOptions<UserSettings>config, IMapper mapper)
        {
            HttpClientFactory = httpClientFactory;
            Config = config;
            Mapper = mapper;
        }
        public FinalResponse CreateEmployee(SampleRequest sampleRequest)
        {
            using(var client = HttpClientFactory.CreateClient("RestApi"))
            {
                using (var response = client.PostAsJsonAsync(Config.Value.RestApi.Url, sampleRequest))
                {
                    var responseBody = response.Result.Content.ReadAsStringAsync().Result;
                    var details = JsonConvert.DeserializeObject<SampleResult>(responseBody);
                    var sampleResponse = new FinalResponse();
                    sampleResponse = Mapper.Map<SampleResult, FinalResponse>(details);
                    return sampleResponse;
                }
            }
        }
    }
}
