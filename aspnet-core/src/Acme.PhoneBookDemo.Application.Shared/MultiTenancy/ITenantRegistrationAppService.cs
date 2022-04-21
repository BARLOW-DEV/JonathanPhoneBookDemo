using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.Editions.Dto;
using Acme.PhoneBookDemo.MultiTenancy.Dto;

namespace Acme.PhoneBookDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}