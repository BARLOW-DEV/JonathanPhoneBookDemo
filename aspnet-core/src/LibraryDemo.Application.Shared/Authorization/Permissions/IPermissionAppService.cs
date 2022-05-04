using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryDemo.Authorization.Permissions.Dto;

namespace LibraryDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
