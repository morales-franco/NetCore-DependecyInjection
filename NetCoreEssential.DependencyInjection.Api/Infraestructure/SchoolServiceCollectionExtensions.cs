using NetCoreEssential.DependencyInjection.Api.IServices;
using NetCoreEssential.DependencyInjection.Api.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SchoolServiceCollectionExtensions
    {
        public static IServiceCollection AddSchoolServices(this IServiceCollection services)
        {
            //Register these services as scope life-time service
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISchoolService, SchoolService>();

            //Register as Singleton
            services.AddSingleton<IBestTeacherService, BestTeacherService>();

            //Chain pattern
            return services;
        }
    }
}
