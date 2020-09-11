using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Configuration.Dto;

namespace DynasysSolution.Configuration
{
    public interface IUiCustomizationSettingsAppService : IApplicationService
    {
        Task<List<ThemeSettingsDto>> GetUiManagementSettings();

        Task UpdateUiManagementSettings(ThemeSettingsDto settings);

        Task UpdateDefaultUiManagementSettings(ThemeSettingsDto settings);

        Task UseSystemDefaultSettings();
    }
}
