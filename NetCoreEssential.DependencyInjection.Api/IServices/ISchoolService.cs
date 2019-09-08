using System.Collections.Generic;

namespace NetCoreEssential.DependencyInjection.Api.IServices
{
    public interface ISchoolService
    {
        List<string> GetAll();

        string GetPublicKey();

        string GetIdentifier();

    }
}
