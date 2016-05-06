using System.Threading.Tasks;
using Abp.Application.Services;
using JesNm.Users.Dto;
using Abp.Application.Services.Dto;

namespace JesNm.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        ListResultOutput<ListAllUserOutput> GetAllUser();

        Task CreateUser(CreateUserInput input);

        User GetUserByUserName(string UserName);
    }
}