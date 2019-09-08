using NetCoreEssential.DependencyInjection.Api.IServices;
using System;

namespace NetCoreEssential.DependencyInjection.Api.Services
{
    public class BestTeacherService : IBestTeacherService
    {
        private readonly string _identifier;

        public BestTeacherService()
        {
            _identifier = Guid.NewGuid().ToString();
        }

        public string GetBestTeacher()
        {
            return $"Best Teacher: { _identifier }";
        }
    }
}
