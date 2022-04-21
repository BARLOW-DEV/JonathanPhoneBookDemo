using System.Collections.Generic;

namespace Acme.PhoneBookDemo.Authorization.Roles.Dto
{
    public class GetRolesInput
    {
        public List<string> Permissions { get; set; }
    }
}
