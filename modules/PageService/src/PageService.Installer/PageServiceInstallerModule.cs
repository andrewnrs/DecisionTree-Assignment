using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PageService;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class PageServiceInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PageServiceInstallerModule>();
        });
    }
}
