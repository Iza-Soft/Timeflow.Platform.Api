using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Middleware.Extensions.Factories;

namespace Timeflow.Platform.Infrastructure.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class UseMiddlewareFactoryExtension
    {
        public static void UseMiddlewareFactory(this WebApplication app)
        {

            /*read out Microsoft.AspNetCore.Http.Abstraction (depricated): https://www.niceonecode.com/question/31142/what-is-alternative-for-microsoft.aspnetcore.http.abstractions-in-.net-6.0-*/
#pragma warning disable CS8604 // Possible null reference argument.
            ProjectDtoFactory.Configure(app.Services.GetService<IMapper>());
            TimesheetDtoFactory.Configure(app.Services.GetService<IMapper>());
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
