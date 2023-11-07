using AutoMapper;
using System.Runtime.CompilerServices;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Extensions.Factories
{
    public static class ProjectDtoFactory
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static IMapper _mapper;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void Configure(IMapper mapper) 
        { 
            _mapper= mapper;
        }

        public static IList<ProjectDto> ToResult(this IList<ProjectEntity> entities) 
        {
            return entities.Select(ToResult).ToList();
        }

        public static ProjectDto ToResult(this ProjectEntity entity) 
        {
            return _mapper.Map<ProjectDto>(entity);
        }
    }
}
