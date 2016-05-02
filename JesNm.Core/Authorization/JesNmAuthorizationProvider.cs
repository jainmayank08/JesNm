using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace JesNm.Authorization
{
    public class JesNmAuthorizationProvider : AuthorizationProvider
    {
        //http://www.aspnetboilerplate.com/Pages/Documents/Authorization
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            //Host permissions
            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);


            var administration = context.CreatePermission(PermissionNames.Administration);

            var userManagement = administration.CreateChildPermission(PermissionNames.Administration_UserManagement);
            userManagement.CreateChildPermission(PermissionNames.Administration_UserManagement_CreateUser);

            var roleManagement = administration.CreateChildPermission(PermissionNames.Administration_RoleManagement);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, JesNmConsts.LocalizationSourceName);
        }
    }
}
