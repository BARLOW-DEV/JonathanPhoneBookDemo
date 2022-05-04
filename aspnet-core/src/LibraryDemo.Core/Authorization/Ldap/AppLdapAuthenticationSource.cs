using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using LibraryDemo.Authorization.Users;
using LibraryDemo.MultiTenancy;

namespace LibraryDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}