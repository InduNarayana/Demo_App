using AutoMapper;
using DemoApp.Models;

namespace DemoApp.Helpers
{
    public class Mapping : Profile
    {
        public Mapping() {
            CreateMap<SampleResult, FinalResponse>()
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Initial, opt => opt.MapFrom(src => src.Body))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Title)); 
        }
    }
}
