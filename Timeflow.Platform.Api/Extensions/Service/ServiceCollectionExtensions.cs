using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.Mappings;
using Timeflow.Platform.Api.Swagger;
using Timeflow.Platform.Api.UseCase.Class;
using Timeflow.Platform.Api.UseCase.Interface;

namespace Timeflow.Platform.Api.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            Type[] profiles = {
                typeof(ProjectAutoMapperProfile),
                typeof(TaskAutoMapperProfile),
            };

            services.AddAutoMapper(profiles);

            return services;
        }

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IBaseUseCase<IList<ProjectResponseViewModel>>, GetProjectsByUserId>();

            return services;
        }

        public static IServiceCollection AddSwaggerGenOptions(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
