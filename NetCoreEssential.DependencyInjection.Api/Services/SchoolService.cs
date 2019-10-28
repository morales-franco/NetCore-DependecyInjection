using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NetCoreEssential.DependencyInjection.Api.Infraestructure.Configuration.ComplexIronPublicKey;
using NetCoreEssential.DependencyInjection.Api.IServices;
using System;
using System.Collections.Generic;

namespace NetCoreEssential.DependencyInjection.Api.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly string _identifier;
        private readonly IConfiguration _configuration;
        private readonly ComplexIronPublicKeyConfiguration _complexIronPublicKey;

        public SchoolService(IConfiguration configuration,
            IOptions<ComplexIronPublicKeyConfiguration> complexIronPublicKey)
        {
            _identifier = Guid.NewGuid().ToString();
            _configuration = configuration;
            _complexIronPublicKey = complexIronPublicKey.Value;
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
            //TODO: Retrieving simple key from appSettings
            //var key = _configuration["IronPublicKey"];

            //TODO: Retrieving a complex using IConfiguration<> key from appSettings
            //var key = GetComplexKeyFromAppSettingsUsingIConfiguration();

            //TODO: Retrieving a complex key using IOptions<> from appSettings
            var key = _complexIronPublicKey.GetPublicKey();

            return key;
        }

        private string GetComplexKeyFromAppSettingsUsingIConfiguration()
        {
            var prefix = _configuration["ComplexIronPublicKey:Prefix"];
            var bodyPartOne = _configuration["ComplexIronPublicKey:Body:PartOne"];
            var bodySeparator = _configuration["ComplexIronPublicKey:Body:Separator"];
            var bodyPartTwoValueA = _configuration["ComplexIronPublicKey:Body:PartTwo:ValueA"];
            var bodyPartTwoSeparator = _configuration["ComplexIronPublicKey:Body:PartTwo:Separator"];
            var bodyPartTwoValueB = _configuration["ComplexIronPublicKey:Body:PartTwo:ValueB"];
            var sufix = _configuration["ComplexIronPublicKey:Sufix"];

            var key = $"{prefix}{bodyPartOne}{bodySeparator}{bodyPartTwoValueA}{bodyPartTwoSeparator}{bodyPartTwoValueB}{sufix}";
            return key;
        }
    }
}
