using System.Collections.Generic;

namespace NetCoreEssential.DependencyInjection.Api.IServices
{
    public interface IStudentService
    {
        List<string> GetAll();
        string GetIdentifier();
    }
}
