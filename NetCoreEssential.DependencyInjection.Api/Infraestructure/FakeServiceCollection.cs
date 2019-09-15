using NetCoreEssential.DependencyInjection.Api.IServices;
using NetCoreEssential.DependencyInjection.Api.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FakeServiceCollection
    {
        public static IServiceCollection AddFakeServices(this IServiceCollection services)
        {
            //Register fake services
            services.AddTransient<IFakeServiceA, FakeServiceA>();
            services.AddTransient<IFakeServiceB, FakeServiceB>();
            services.AddTransient<IFakeServiceC, FakeServiceC>();
            services.AddTransient<IFakeServiceD, FakeServiceD>();
            services.AddTransient<IFakeServiceE, FakeServiceE>();
            services.AddTransient<IFakeServiceF, FakeServiceF>();
            services.AddTransient<IFakeServiceG, FakeServiceG>();
            services.AddTransient<IFakeServiceH, FakeServiceH>();
            services.AddTransient<IFakeServiceI, FakeServiceI>();
            services.AddTransient<IFakeServiceJ, FakeServiceJ>();

            //Chain Pattern
            return services;
        }
    }
}
