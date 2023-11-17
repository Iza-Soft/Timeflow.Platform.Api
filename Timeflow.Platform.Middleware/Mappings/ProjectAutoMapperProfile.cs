using AutoMapper;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Mappings
{
    public class ProjectAutoMapperProfile : Profile
    {
        public ProjectAutoMapperProfile() 
        {
            CreateMap<ProjectEntity, ProjectDto>().ForMember(dest => dest.Tasks, opt => opt.MapFrom(src => src.Tasks)).ReverseMap();
        }
    }
}
