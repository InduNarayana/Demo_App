

using DemoApp.Models;

namespace DemoApp.Repositories.Interfaces
{
    public interface ISampleRepository
    {
        FinalResponse CreateEmployee(SampleRequest sampleRequest);
    }
}
