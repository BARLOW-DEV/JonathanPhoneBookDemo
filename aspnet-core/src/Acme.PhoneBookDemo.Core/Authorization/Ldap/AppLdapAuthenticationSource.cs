using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Acme.PhoneBookDemo.Authorization.Users;
using Acme.PhoneBookDemo.MultiTenancy;

namespace Acme.PhoneBookDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}