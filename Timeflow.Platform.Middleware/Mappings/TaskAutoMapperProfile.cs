using AutoMapper;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Mappings
{
    public class TaskAutoMapperProfile : Profile
    {
        public TaskAutoMapperProfile()
        {
            CreateMap<TaskEntity, TaskDto>().ReverseMap();
        }
    }
}
