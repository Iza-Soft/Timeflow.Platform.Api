using AutoMapper;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Mappings
{
    public class ProjectAutoMapperProfile : Profile
    {
        public ProjectAutoMapperProfile() 
        {
            CreateMap<ProjectEntity, ProjectDto>().ReverseMap();
        }
    }
}
