
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
            CreateMap<ProgramDetails, ProgramDetailsDto>().ReverseMap();
            CreateMap<WorkFlow, WorkFlowDto>().ReverseMap();
            CreateMap<ApplicationForm, ApplicationFormDto>().ReverseMap();
        }
    }
}