using Abp.Authorization;
using DynasysSolution.Authorization.Roles;
using DynasysSolution.Authorization.Users;

namespace DynasysSolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
