using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using DynasysSolution.Authorization.Users;
using DynasysSolution.MultiTenancy;

namespace DynasysSolution.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}