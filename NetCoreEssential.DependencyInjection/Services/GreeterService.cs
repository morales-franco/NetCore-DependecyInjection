using NetCoreEssential.DependencyInjection.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreEssential.DependencyInjection.Services
{
    class GreeterService: IGreeterService
    {
        public Guid Id { get; private set; }

        public GreeterService()
        {
            Id = Guid.NewGuid();
            Console.WriteLine($"Created { nameof(GreeterService) } - Instance Id: { Id.ToString() }");
        }

        public string SayHello()
        {
            return "Hello";
        }
    }
}
