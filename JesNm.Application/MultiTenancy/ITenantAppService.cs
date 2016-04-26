using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JesNm.MultiTenancy.Dto;

namespace JesNm.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
