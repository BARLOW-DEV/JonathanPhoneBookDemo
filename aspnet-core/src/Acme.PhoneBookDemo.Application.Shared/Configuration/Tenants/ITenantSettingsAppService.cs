using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.Configuration.Tenants.Dto;

namespace Acme.PhoneBookDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
