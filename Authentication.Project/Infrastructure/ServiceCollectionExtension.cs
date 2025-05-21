using Authentication.Database.Infrastructure;
using Authentication.Service.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Project.Infrastructure;

internal static class ServiceCollectionExtension 
{
    public static void AddSharedServices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
    {
        services.AddApplication(configuration);

        var connectionString = new DatabaseSettings();
        configuration.GetSection("DatabaseConfig").Bind(connectionString);

        services.AddDbContextPool<DbContexts>(options => options.UseNpgsql(connectionString.ConnectionString));

        services.AddDatabase(configuration);
    }
}
