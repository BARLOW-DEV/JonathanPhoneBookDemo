using System.Collections.Generic;
using Acme.PhoneBookDemo.Authorization.Permissions.Dto;

namespace Acme.PhoneBookDemo.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}