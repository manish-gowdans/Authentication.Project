using Authentication.Database.Components.User;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Database.Infrastructure;
public static class ServiceExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IRegisterData, RegisterData>();
        return services;
    }
}
