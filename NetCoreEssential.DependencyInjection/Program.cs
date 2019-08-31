using Microsoft.Extensions.DependencyInjection;
using NetCoreEssential.DependencyInjection.IServices;
using NetCoreEssential.DependencyInjection.Services;
using System;

namespace NetCoreEssential.DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection");

            //container
            var services = new ServiceCollection();

            //Register services
            services.AddSingleton<IGreeterService, GreeterService>();
            //services.AddTransient<IGreeterService, GreeterService>();
            //services.AddScoped<IGreeterService, GreeterService>();
            services.AddTransient<IReaderService>(sp =>
            {
                return new ReaderService("the call of the wild");
            });

            //Provider or Interface of the container. 
            //We can request instances to the service.
            //Ey provider, I need a IGreeterService Instance, please
            var serviceProvider = services.BuildServiceProvider();

            var greeterA = serviceProvider.GetService<IGreeterService>();
            var greeterB = serviceProvider.GetService<IGreeterService>();
            var reader = serviceProvider.GetService<IReaderService>();

            Console.WriteLine(reader.GetFavouriteBook());

            PrintHash(greeterA);
            PrintHash(greeterB);

            //Create our own scope
            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                Console.WriteLine("My scope");
                var greeterC = scope.ServiceProvider.GetService<IGreeterService>();
                PrintHash(greeterC);
            }


            Console.ReadLine();
        }

        static void PrintHash(object obj)
        {
            Console.WriteLine(obj.GetHashCode().ToString());
        }
    }
}
