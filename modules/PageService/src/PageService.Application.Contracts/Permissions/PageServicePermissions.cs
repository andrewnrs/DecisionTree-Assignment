using Volo.Abp.Reflection;

namespace PageService.Permissions;

public class PageServicePermissions
{
    public const string GroupName = "PageService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(PageServicePermissions));
    }
}
