
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
// Some usings from GlobalUsings.cs

namespace Microsoft.Extensions.DependencyInjection;// Simplfy

public static class DependencyInjection
{
    /// <summary>
    /// Register Application Services.
    /// Using 
    /// Mediatr >
    /// AutoMapper >
    /// FluentValidation >
    /// </summary>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
