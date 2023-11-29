using AutoMapper;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.Extensions.Utilities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Mappings
{
    public class TaskAutoMapperProfile : Profile
    {
        public TaskAutoMapperProfile()
        {
            CreateMap<TaskDto, TaskResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                //.ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.ServiceTypeId))
                //.ForMember(dest => dest.ServiceType, opt => opt.MapFrom(src => src.ServiceTypeId.ToDescription()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
                //.ReverseMap();
        }
    }
}