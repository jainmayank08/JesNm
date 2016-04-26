using System.Threading.Tasks;
using Abp.Application.Services;
using JesNm.Roles.Dto;

namespace JesNm.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
