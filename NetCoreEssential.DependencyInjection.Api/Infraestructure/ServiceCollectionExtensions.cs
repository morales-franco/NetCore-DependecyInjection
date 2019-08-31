using NetCoreEssential.DependencyInjection.Api.IServices;
using NetCoreEssential.DependencyInjection.Api.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIronServices(this IServiceCollection services)
        {
            services.AddScoped<IGreeterService, GreeterService>();
            return services;
        }
    }
}
