using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Runtime.Caching;
using Abp.Zero.Configuration;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Authorization.Roles
{
    public class RoleManager : AbpRoleManager<Tenant, Role, User>
    {
        public RoleManager(
            RoleStore store,
            IPermissionManager permissionManager,
            IRoleManagementConfig roleManagementConfig,
            ICacheManager cacheManager)
            : base(
                store,
                permissionManager,
                roleManagementConfig,
                cacheManager)
        {
        }
    }
}