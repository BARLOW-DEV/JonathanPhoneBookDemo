using Abp.Authorization;
using Acme.PhoneBookDemo.Authorization.Roles;
using Acme.PhoneBookDemo.Authorization.Users;

namespace Acme.PhoneBookDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
