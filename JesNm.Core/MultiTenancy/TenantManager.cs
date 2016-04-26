using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using JesNm.Authorization.Roles;
using JesNm.Editions;
using JesNm.Users;

namespace JesNm.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}