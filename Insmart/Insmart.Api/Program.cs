using FluentValidation;
using FluentValidation.AspNetCore;
using Insmart.Application.Features.Auth.Queries;
using Insmart.Core;
using Insmart.Core.Configs;
using Insmart.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Elasticsearch;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


var corsPolicy = "_inSmartCorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicy,
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.
ConfigureLogging();
builder.Host.UseSerilog();

builder.Services.AddValidatorsFromAssemblyContaining<LoginQueryValidator>();
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddHttpClient();
builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = c =>
        {
            var errors = c.ModelState.Values.Where(v => v.Errors.Count > 0)
              .SelectMany(v => v.Errors)
              .Select(v => v.ErrorMessage);

            return new BadRequestObjectResult(new ApiResponse<bool>
            {
                Message = "Invalid request. Please see errors for more information",
                Errors = errors.ToList()
            });
        };
    });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning();

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddInfrastructure();
builder.Services.AddMediatR(typeof(Insmart.Application.Interfaces.IUnitOfWork).Assembly);

var appSettings = new AppSettings();
builder.Configuration.Bind("AppSettings", appSettings);
builder.Services.AddSingleton(appSettings);


builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(corsPolicy);
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

void ConfigureLogging()
{
    //var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile(
            $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
            optional: true)
        .Build();

    Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .Enrich.WithEnvironmentName()
            .WriteTo.Console()
            //.WriteTo.Elasticsearch(ConfigureElasticSink(configuration, environment))
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
}

ElasticsearchSinkOptions ConfigureElasticSink(IConfigurationRoot configuration, string environment)
{
    return new ElasticsearchSinkOptions(new Uri(configuration["ElasticConfiguration:Uri"]))
    {
        AutoRegisterTemplate = true,
        AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv6,
        IndexFormat = $"{Assembly.GetExecutingAssembly().GetName().Name.ToLower().Replace(".", "-")}-{environment?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}"
    };
}