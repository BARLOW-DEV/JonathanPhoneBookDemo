using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Acme.PhoneBookDemo.Authorization.Permissions.Dto;

namespace Acme.PhoneBookDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
