using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Configuration.Tenants.Dto;

namespace DynasysSolution.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
