using Abp.Authorization;
using LibraryDemo.Authorization.Roles;
using LibraryDemo.Authorization.Users;

namespace LibraryDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
