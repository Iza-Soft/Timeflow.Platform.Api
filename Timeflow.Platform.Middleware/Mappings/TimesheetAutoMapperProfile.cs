using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Mappings
{
    public class TimesheetAutoMapperProfile : Profile
    {
        public TimesheetAutoMapperProfile()
        {
            CreateMap<TimeSheetEntity, TimesheetDto>()
                .ForMember(dest => dest.Task, opt => opt.MapFrom(src => src.Task))
                .ReverseMap();
        }
    }
}
