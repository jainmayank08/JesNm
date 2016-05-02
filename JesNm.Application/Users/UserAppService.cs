using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using JesNm.Users.Dto;
using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;

namespace JesNm.Users
{
    /* THIS IS JUST A SAMPLE. */
    public class UserAppService : JesNmAppServiceBase, IUserAppService
    {
        private readonly UserManager _userManager;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(UserManager userManager, IPermissionManager permissionManager)
        {
            _userManager = userManager;
            _permissionManager = permissionManager;
        }

        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await _userManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await _userManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async Task RemoveFromRole(long userId, string roleName)
        {
            CheckErrors(await _userManager.RemoveFromRoleAsync(userId, roleName));
        }


        public ListResultOutput<ListAllUserOutput> GetAllUser()
        {
            return new ListResultOutput<ListAllUserOutput>(
              _userManager.Users.ToList()
              .MapTo<List<ListAllUserOutput>>());
        }
    }
}