using Abp.Application.Services;
using LibraryDemo.Dto;
using LibraryDemo.Logging.Dto;

namespace LibraryDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
