using AutoMapper;
using System.Diagnostics.CodeAnalysis;
using Timeflow.Platform.Api.Extensions.Factories;

namespace Timeflow.Platform.Api.Extensions.Service
{
    [ExcludeFromCodeCoverage]
    public static class UseFactoryExtension
    {
        public static void UseFactory(this WebApplication app)
        {

            /*read out Microsoft.AspNetCore.Http.Abstraction (depricated): https://www.niceonecode.com/question/31142/what-is-alternative-for-microsoft.aspnetcore.http.abstractions-in-.net-6.0-*/
#pragma warning disable CS8604 // Possible null reference argument.
            ProjectResponseFactory.Configure(app.Services.GetService<IMapper>());
            TimesheetRequestFactory.Configure(app.Services.GetService<IMapper>());
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
