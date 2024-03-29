using PageService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PageService.Permissions;

public class PageServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PageServicePermissions.GroupName, L("Permission:PageService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PageServiceResource>(name);
    }
}
