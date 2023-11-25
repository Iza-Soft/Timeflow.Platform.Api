using AutoMapper;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Mappings
{
    public class ProjectAutoMapperProfile : Profile
    {
        public ProjectAutoMapperProfile()
        {
            CreateMap<ProjectResponse, ProjectDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src => src.Tasks))
                .ReverseMap();
        }
    }
}
