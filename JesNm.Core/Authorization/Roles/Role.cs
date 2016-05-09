using Abp.Authorization.Roles;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

        public static Role CreateRole(string displayName, string name, bool  isStatic, bool isDefault)
        {
            return new Role
            {
                Name = name,
                DisplayName = displayName,
                IsStatic = isStatic,
                IsDefault = isDefault,                  
            };
        }
    }
}