using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEssential.DependencyInjection.Api.Infraestructure.Configuration.ComplexIronPublicKey;

namespace NetCoreEssential.DependencyInjection.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            /*
             * TODO: Clean code - Services Regsitration - We created a Extension Methods
             * AddSchoolServices()
             * AddFakeServices()
             * To register our services ;) 
            
            ALL THESE SERVICES ARE REGISTERED IN AddSchoolServices():
            Register these services as scope life-time service:
            * services.AddScoped<IStudentService, StudentService>();
            * services.AddScoped<ISchoolService, SchoolService>();
            
            Register as Singleton
            * services.AddSingleton<IBestTeacherService, BestTeacherService>();

            ALL THESE SERVICES ARE REGISTERED IN AddFakeServices();
            Register fake services:
            * services.AddTransient<IFakeServiceA, FakeServiceA>();
            * services.AddTransient<IFakeServiceB, FakeServiceB>();
            * services.AddTransient<IFakeServiceC, FakeServiceC>();
            * services.AddTransient<IFakeServiceD, FakeServiceD>();
            * services.AddTransient<IFakeServiceE, FakeServiceE>();
            * services.AddTransient<IFakeServiceF, FakeServiceF>();
            * services.AddTransient<IFakeServiceG, FakeServiceG>();
            * services.AddTransient<IFakeServiceH, FakeServiceH>();
            * services.AddTransient<IFakeServiceI, FakeServiceI>();
            * services.AddTransient<IFakeServiceJ, FakeServiceJ>();
            * 
            */
            services.AddSchoolServices()
                .AddFakeServices()
                .AddAppConfiguration(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
