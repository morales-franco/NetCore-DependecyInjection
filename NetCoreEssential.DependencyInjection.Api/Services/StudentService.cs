using NetCoreEssential.DependencyInjection.Api.IServices;
using System;
using System.Collections.Generic;

namespace NetCoreEssential.DependencyInjection.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly string _identifier;

        public StudentService()
        {
            _identifier = Guid.NewGuid().ToString();
        }
        public List<string> GetAll()
        {
            return new List<string>
            {
                "Student1",
                "Student2",
                "Student3"
            };
        }

        public string GetIdentifier()
        {
            return _identifier;
        }
    }
}
