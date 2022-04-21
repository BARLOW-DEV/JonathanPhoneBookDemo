using Abp.Application.Services;
using Acme.PhoneBookDemo.Dto;
using Acme.PhoneBookDemo.Logging.Dto;

namespace Acme.PhoneBookDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
