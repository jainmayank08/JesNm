using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using JesNm.Users.Dto;
using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using JesNm.Authorization.Roles;

namespace JesNm.Users
{
    /* THIS IS JUST A SAMPLE. */
    public class UserAppService : JesNmAppServiceBase, IUserAppService
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(UserManager userManager, IPermissionManager permissionManager, RoleManager roleManager)
        {
            _userManager = userManager;
            _permissionManager = permissionManager;
            _roleManager = roleManager;
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

        public async Task CreateUser(CreateUserInput input)
        {
             var user  = User.CreateMemberUser(input.UserName , input.Name , input.Surname , input.EmailAddress, input.Password);
             CheckErrors(await _userManager.CreateAsync(user));
             await CurrentUnitOfWork.SaveChangesAsync();

            //assign role to the user 
             var memberRole = _roleManager.Roles.Single(r => r.Name == StaticRoleNames.Host.Member);
             await _roleManager.GrantAllPermissionsAsync(memberRole);

             CheckErrors(await _userManager.AddToRoleAsync(user.Id, memberRole.Name));
             await CurrentUnitOfWork.SaveChangesAsync();
            
        }
    }
}