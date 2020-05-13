using AbpIoAngular.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpIoAngular.Permissions
{
    public class AbpIoAngularPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpIoAngularPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpIoAngularPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpIoAngularResource>(name);
        }
    }
}
