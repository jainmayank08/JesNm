using Abp.Application.Features;
using JesNm.Authorization.Roles;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}