using NetCoreEssential.DependencyInjection.Api.IServices;
using System;
using System.Collections.Generic;

namespace NetCoreEssential.DependencyInjection.Api.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly string _identifier;

        public SchoolService()
        {
            _identifier = Guid.NewGuid().ToString();
        }
        public List<string> GetAll()
        {
            //Go to the bd!
            return new List<string>
            {
                "School1",
                "School2",
                "School3"
            };
        }

        public string GetIdentifier()
        {
            return _identifier;
        }

        public string GetPublicKey()
        {
            //todo: retrieve to the config
            return "### PUBLIC KEY ###";
        }
    }
}
