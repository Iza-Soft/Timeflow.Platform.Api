using AutoMapper;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Mappings
{
    public class TimesheetAutoMapperProfile : Profile
    {
        public TimesheetAutoMapperProfile()
        {
            CreateMap<TimeSheetEntity, TimesheetDto>().ReverseMap();
        }
    }
}
