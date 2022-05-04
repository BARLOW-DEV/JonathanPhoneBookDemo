using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.Configuration.Tenants.Dto;

namespace LibraryDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
