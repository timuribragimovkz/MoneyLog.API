namespace MoneyLog.API.StartupExtensions;

public static class ConfigurationRegistration
{
    public static IConfiguration RegisterConfiguration(this IServiceCollection services)
    {
        var configurationBuilder = new ConfigurationBuilder();
        configurationBuilder.AddJsonFile("appsettings.json");
        var configuration = configurationBuilder.Build();
        services.AddSingleton(configuration);

        return configuration;
    }
}