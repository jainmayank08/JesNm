using Abp.Authorization;
using JesNm.Authorization.Roles;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
