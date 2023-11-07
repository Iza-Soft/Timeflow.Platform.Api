using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Middleware.Mappings;

namespace Timeflow.Platform.Middleware.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMiddlewareAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ProjectAutoMapperProfile));

            return services;
        }
    }
}
