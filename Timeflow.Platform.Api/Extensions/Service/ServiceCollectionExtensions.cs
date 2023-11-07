using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Api.Mappings;

namespace Timeflow.Platform.Api.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ProjectAutoMapperProfile));

            return services;
        }
    }
}
