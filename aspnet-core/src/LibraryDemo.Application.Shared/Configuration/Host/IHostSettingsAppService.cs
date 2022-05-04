using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.Configuration.Host.Dto;

namespace LibraryDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
