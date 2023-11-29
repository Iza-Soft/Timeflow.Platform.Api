using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Extensions.Factories
{
    public static class TimesheetDtoFactory
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static IMapper _mapper;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void Configure(IMapper mapper)
        {
            _mapper = mapper;
        }

        public static IList<TimesheetDto> ToResult(this IList<TimeSheetEntity> entities)
        {
            return entities.Select(ToResult).ToList();
        }

        public static TimesheetDto ToResult(this TimeSheetEntity entity)
        {
            return _mapper.Map<TimesheetDto>(entity);
        }
    }
}
