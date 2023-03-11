
using AutoMapper;
using InterviewTask.Models.Dtos;
using MiskSchool.Models.Dtos;
using MiskSchool.Models.Entities;

namespace MiskSchool.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ProgramDetails, ProgramDetailsDto>().ReverseMap()
                .ForMember(dest => dest.Id, o => o.MapFrom(guid => Guid.NewGuid().ToString()));
            CreateMap<WorkFlow, WorkFlowDto>().ReverseMap()
               .ForMember(dest => dest.Id, o => o.MapFrom(guid => Guid.NewGuid().ToString()));
            CreateMap<ApplicationForm, ApplicationFormDto>().ReverseMap()
              .ForMember(dest => dest.Id, o => o.MapFrom(guid => Guid.NewGuid().ToString()));
        }
    }
}