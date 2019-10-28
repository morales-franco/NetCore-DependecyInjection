using Microsoft.Extensions.Configuration;
using NetCoreEssential.DependencyInjection.Api.Infraestructure.Configuration.ComplexIronPublicKey;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigurationServiceCollectionExtensions
    {
        public static IServiceCollection AddAppConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ComplexIronPublicKeyConfiguration>(configuration.GetSection("ComplexIronPublicKey"));
            return services;
        }
    }
}
