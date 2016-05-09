using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using JesNm.Authorization.Roles;
using JesNm.Roles.Dto;

namespace JesNm.Roles
{
    /* THIS IS JUST A SAMPLE. */
    public class RoleAppService : JesNmAppServiceBase,IRoleAppService
    {
        private readonly RoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;

        public RoleAppService(RoleManager roleManager, IPermissionManager permissionManager)
        {
            _roleManager = roleManager;
            _permissionManager = permissionManager;
        }

        public async Task UpdateRolePermissions(UpdateRolePermissionsInput input)
        {
            var role = await _roleManager.GetRoleByIdAsync(input.RoleId);
            var grantedPermissions = _permissionManager
                .GetAllPermissions()
                .Where(p => input.GrantedPermissionNames.Contains(p.Name))
                .ToList();

            await _roleManager.SetGrantedPermissionsAsync(role, grantedPermissions);
        }

        public async Task CreateRole(CreateRolesInput input)
        {
            var role = Role.CreateRole(input.DisplayName, input.Name, input.IsStatic, input.IsDefault);
            CheckErrors(await _roleManager.CreateAsync(role));
            await CurrentUnitOfWork.SaveChangesAsync();             
        }
    }
}