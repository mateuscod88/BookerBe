using Booker.Application.Shared.Abstraction;
using Booker.Infrastructure.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Booker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ILogingManager,LogingManager>();
        return services;
    }
}