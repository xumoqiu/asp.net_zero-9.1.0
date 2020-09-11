using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Editions.Dto;
using DynasysSolution.MultiTenancy.Dto;

namespace DynasysSolution.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}