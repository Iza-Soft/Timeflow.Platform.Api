using AutoMapper;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Extensions.Factories
{
    public static class ProjectResponseFactory
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static IMapper _mapper;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void Configure(IMapper mapper)
        {
            _mapper = mapper;
        }

        public static IList<ProjectResponse> ToResponse(this IList<ProjectDto> entities)
        {
            return entities.Select(ToResponse).ToList();
        }

        public static ProjectResponse ToResponse(this ProjectDto entity)
        {
            return _mapper.Map<ProjectResponse>(entity);
        }
    }
}
