using Abp.Authorization.Roles;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}