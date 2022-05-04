using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryDemo.Common.Dto;
using LibraryDemo.Editions.Dto;

namespace LibraryDemo.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}