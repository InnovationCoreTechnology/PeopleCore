using ICT.PeopleCore.Repository.Services;
using ICT.PeopleCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Text.Json;

namespace ICT.PeopleCore.Helper
{
    public static class ServiceCollectionExtensions
    {
        // Registers your service, repository, and helper layers
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddServiceLayer();
            services.AddRepositoryLayer();
            services.AddHelperLayer();
            return services;
        }

        // Registers Swagger services
        public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "PeopleCore API",
                    Version = "v1",
                    Description = "API for PeopleCore services"
                });
            });
            return services;
        }

        // Configures global error handling middleware
        public static IApplicationBuilder UseGlobalErrorHandling(this IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var errorFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (errorFeature != null)
                    {
                        var ex = errorFeature.Error;
                        Console.WriteLine($"[Global Error] {ex.Message} | {ex.StackTrace}");

                        var result = JsonSerializer.Serialize(new
                        {
                            Error = true,
                            Message = "An unexpected error occurred.",
                            Details = ex.Message
                        });

                        await context.Response.WriteAsync(result);
                    }
                });
            });

            return app;
        }
    }
}
