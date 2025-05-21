using Authentication.Service.Components.User.Register;
using Authentication.Service.Components.User.Token;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Service.Infrastructure;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IRegisterService, RegisterService>();
        services.AddTransient<ITokenService, TokenService>();
        return services;
    }
}
