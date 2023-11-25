using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Timeflow.Platform.Api.Extensions.Service;
using Timeflow.Platform.Api.Swagger;
using Timeflow.Platform.Authentication.Extensions.Service;
using Timeflow.Platform.Authentication.Settings;
using Timeflow.Platform.Infrastructure.Extensions.Service;
using Timeflow.Platform.Middleware.Extensions.Service;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region Add services to the container

builder.Services.AddDdManagement(configuration);

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();

builder.Services.AddUseCases();

builder.Services.AddRepositoryPattern();
builder.Services.AddUnitOfWorkPattern();
builder.Services.AddProxyPattern();

builder.Services.AddSwaggerGenOptions();
builder.Services.AddSwaggerGen(options =>
{
    // Add a custom operation filter which sets default values
    options.OperationFilter<SwaggerDefaultValues>();

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
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

builder.Services.AddAutoMapperProfiles();
builder.Services.AddMiddlewareAutoMapperProfiles();

//Jwt configuration starts here

JwtSettings jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtSettings>();

builder.Services.AddAuthentication(opt => {
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
 {
     options.TokenValidationParameters = new TokenValidationParameters
     {
         ValidateIssuer = true,
         ValidateAudience = true,
         ValidateLifetime = true,
         ValidateIssuerSigningKey = true,
         ValidIssuer = jwtSettings.Issuer,
         ValidAudience = jwtSettings.Audience,
         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecurityKey))
     };
     options.Events = new JwtBearerEvents
     {
         /*
          * https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.authentication.jwtbearer.jwtbearerevents?view=aspnetcore-7.0
          * https://sandrino.dev/blog/aspnet-core-5-jwt-authorization
          */
         OnChallenge = async (context) => {
             context.HandleResponse();
             context.Response.StatusCode = StatusCodes.Status401Unauthorized;
             context.Response.ContentType = "application/json";

             context.Error = "Request Access Denied";

             if (context.AuthenticateFailure != null)
             {
                 if (context.AuthenticateFailure.GetType() == typeof(SecurityTokenExpiredException))
                 {
                     var authenticationException = context.AuthenticateFailure as SecurityTokenExpiredException;
                     context.ErrorDescription = "The token has expired";
                 }
                 else context.ErrorDescription = "Token validation has failed";

             }
             else
             {
                 context.ErrorDescription = "Òhe provision of a valid token is required";
             }

             await context.Response.WriteAsync(JsonConvert.SerializeObject(new
             {
                 Message = context.Error,
                 Description = context.ErrorDescription
             }));
         }

     };
 });
//Jwt configuration ends here

builder.Services.AddAuthorizeLibrary();

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("MyPolicy", builder =>
//    {
//        builder.WithOrigins("http://timeflow.iza-soft.com")
//                .WithMethods("GET")
//                .WithHeaders("content-type")
//                .WithExposedHeaders("content-type");
//    });
//});
#endregion

var app = builder.Build();

app.UseFactory();
app.UseMiddlewareFactory();

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
app.UseRouting();

//TODO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! this must be change !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//app.UseCors("MyPolicy");
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
//TODO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! this must be change !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



app.Run();
