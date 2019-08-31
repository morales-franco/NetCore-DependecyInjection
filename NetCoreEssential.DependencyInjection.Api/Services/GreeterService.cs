using NetCoreEssential.DependencyInjection.Api.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEssential.DependencyInjection.Api.Services
{
    public class GreeterService : IGreeterService
    {
        public string GetGreeting()
        {
            return "Hello everyone, have a great day!";
        }
    }
}
