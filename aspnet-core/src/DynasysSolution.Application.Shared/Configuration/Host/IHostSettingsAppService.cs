using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Configuration.Host.Dto;

namespace DynasysSolution.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
