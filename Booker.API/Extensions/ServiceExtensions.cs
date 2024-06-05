using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Booker.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection service)
    {
        service.AddCors(options =>
        {
            options.AddPolicy("BookerPolicy", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });

        });
        
    }
}