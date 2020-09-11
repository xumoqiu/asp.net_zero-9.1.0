using Abp.Domain.Services;

namespace DynasysSolution
{
    public abstract class DynasysSolutionDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected DynasysSolutionDomainServiceBase()
        {
            LocalizationSourceName = DynasysSolutionConsts.LocalizationSourceName;
        }
    }
}
