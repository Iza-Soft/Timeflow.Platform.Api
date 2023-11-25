using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Middleware.Mappings;
using Timeflow.Platform.Middleware.Patterns.Proxy.Class;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Middleware.Patterns.UnitOfWork.Class;
using Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface;

namespace Timeflow.Platform.Middleware.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMiddlewareAutoMapperProfiles(this IServiceCollection services)
        {
            Type[] profiles = { 
                typeof(ProjectAutoMapperProfile), 
                typeof(TaskAutoMapperProfile) 
            };

            services.AddAutoMapper(profiles);

            return services;
        }

        public static IServiceCollection AddProxyPattern(this IServiceCollection services)
        {
            services.AddScoped<IProjectProxy, ProjectProxy>();
            services.AddScoped<ITimesheetProxy, TimesheetProxy>();

            return services;
        }

        public static IServiceCollection AddUnitOfWorkPattern(this IServiceCollection services)
        {
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            return services;
        }
    }
}
