using Asp.Versioning;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.Swagger;
using Timeflow.Platform.Api.UseCase.Class;
using Timeflow.Platform.Api.UseCase.Interface;
using Timeflow.Platform.Infrastructure;
using Timeflow.Platform.Infrastructure.Extensions.Service;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Class;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Middleware.Patterns.Proxy.Class;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region Add services to the container

builder.Services.AddDdManagement(configuration);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient<DbContext, TimeFlowContext>();
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();

builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

builder.Services.AddScoped<IBaseUseCase<IList<ProjectResponseViewModel>>, GetProjectsByUserId>();

builder.Services.AddScoped<IProjectProxy, ProjectProxy>();

builder.Services.AddSwaggerGen(options =>
{
    // Add a custom operation filter which sets default values
    options.OperationFilter<SwaggerDefaultValues>();

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver"));
}).AddApiExplorer(options => {
    // Add the versioned API explorer, which also adds IApiVersionDescriptionProvider service
    // note: the specified format code will format the version as "'v'major[.minor][-status]"
    options.GroupNameFormat = "'v'VVV";

    // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
    // can also be used to control the format of the API version in route templates
    options.SubstituteApiVersionInUrl = true;
}).AddMvc();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var descriptions = app.DescribeApiVersions();
        //var descriptions = app.DescribeApiVersions().Reverse(); /*will display all api version in reverse order*/

        // Build a swagger endpoint for each discovered API version
        foreach (var description in descriptions)
        {
            var url = $"/swagger/{description.GroupName}/swagger.json";
            var name = description.GroupName.ToUpperInvariant();
            options.SwaggerEndpoint(url, $"Timeflow API { name }");
        }
    });
    app.UseSwagger(options => { options.RouteTemplate = "api-docs/{documentName}/docs.json"; });
    app.UseSwaggerUI(options =>
    {
        options.RoutePrefix = "api-docs";
        foreach (var description in app.DescribeApiVersions())
            options.SwaggerEndpoint($"/api-docs/{description.GroupName}/docs.json", description.GroupName.ToUpperInvariant());
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
