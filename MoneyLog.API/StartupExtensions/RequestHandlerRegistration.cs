using MoneyLog.Application.Handlers.Interfaces;

namespace MoneyLog.API.StartupExtensions;

public static class RequestHandlerRegistration
{
    public static IServiceCollection RegisterRequestHandlers(this IServiceCollection services)
    {
        services.Scan(scan => 
            scan.FromAssemblies()
                .FromApplicationDependencies()
                .AddClasses(classes => classes.AssignableTo(typeof(IHandler<,>)))
                .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}