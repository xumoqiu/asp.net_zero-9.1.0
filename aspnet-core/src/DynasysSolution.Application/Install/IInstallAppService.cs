using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.Install.Dto;

namespace DynasysSolution.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}