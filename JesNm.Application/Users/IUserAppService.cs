using System.Threading.Tasks;
using Abp.Application.Services;
using JesNm.Users.Dto;

namespace JesNm.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}