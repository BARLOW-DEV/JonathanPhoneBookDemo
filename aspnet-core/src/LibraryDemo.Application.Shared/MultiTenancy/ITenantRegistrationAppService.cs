using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.Editions.Dto;
using LibraryDemo.MultiTenancy.Dto;

namespace LibraryDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}