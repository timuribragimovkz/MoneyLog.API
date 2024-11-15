using MoneyLog.Infrastructure.MongoDb.Configs;

namespace MoneyLog.API.StartupExtensions;

public static class OptionsRegistration
{
    public static IServiceCollection RegisterOptions(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.Configure<MongoDbOptions>(configuration.GetSection(nameof(MongoDbOptions)));

        return services;
    }
}