using MoneyLog.Infrastructure.MongoDb.Interfaces;

namespace MoneyLog.API.StartupExtensions;

public static class MongoDbRegistration
{
    public static IServiceCollection RegisterMongoDb(this IServiceCollection services)
    {
        services.Scan(scan =>
            scan.FromAssemblies()
                .FromApplicationDependencies()
                .AddClasses(classes => classes.AssignableTo(typeof(IMongoDb)))
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

        return services;
    }
}