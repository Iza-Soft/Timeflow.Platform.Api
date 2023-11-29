using AutoMapper;
using Timeflow.Platform.Api.Boundary.Request.Class;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Extensions.Factories
{
    public static class TimesheetRequestFactory
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static IMapper _mapper;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void Configure(IMapper mapper)
        {
            _mapper = mapper;
        }

        public static TimesheetDto ToRequest(this TimesheetQuery model)
        {
            return _mapper.Map<TimesheetDto>(model);
        }

        public static IList<TimesheetResponse> ToResponse(this IList<TimesheetDto> entities)
        {
            return entities.Select(ToResponse).ToList();
        }

        public static TimesheetResponse ToResponse(this TimesheetDto entity)
        {
            return _mapper.Map<TimesheetResponse>(entity);
        }
    }
}
