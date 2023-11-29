using AutoMapper;
using System.Globalization;
using Timeflow.Platform.Api.Boundary.Request.Class;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.Extensions.Utilities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Mappings
{
    public class TimesheetAutoMapperProfile : Profile
    {
        public TimesheetAutoMapperProfile()
        {
            CreateMap<TimesheetQuery, TimesheetDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.DayOfMonth, opt => opt.MapFrom(src => src.Date.Day))
                .ForMember(dest => dest.WeekOfYear, opt => opt.MapFrom(src => CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(src.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)))
                .ForMember(dest => dest.MonthOfYear, opt => opt.MapFrom(src => src.Date.Month))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Date.Year));
            //.ReverseMap();

            CreateMap<TimesheetDto, TimesheetResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Task.Project.Title))
                .ForMember(dest => dest.TaskName, opt => opt.MapFrom(src => src.Task.Title))
                .ForMember(dest => dest.ServiceType, opt => opt.MapFrom(src => src.ServiceTypeId.ToDescription()))
                .ForMember(dest => dest.WorkingHours, opt => opt.MapFrom(src => src.WorkingHours))
                .ForMember(dest => dest.PaymentAmount, opt => opt.MapFrom(src => src.Task.PaymentAmount))
                .ForMember(dest => dest.PaymentType, opt => opt.MapFrom(src => src.Task.PaymentTypeId.ToDescription()))
                .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy));
                //.ReverseMap();
        }
    }
}
