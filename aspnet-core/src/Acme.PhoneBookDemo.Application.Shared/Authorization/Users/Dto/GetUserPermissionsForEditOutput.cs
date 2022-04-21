using System.Collections.Generic;
using Acme.PhoneBookDemo.Authorization.Permissions.Dto;

namespace Acme.PhoneBookDemo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}