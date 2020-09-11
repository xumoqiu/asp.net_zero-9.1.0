using Abp.Application.Services;
using DynasysSolution.Dto;
using DynasysSolution.Logging.Dto;

namespace DynasysSolution.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
