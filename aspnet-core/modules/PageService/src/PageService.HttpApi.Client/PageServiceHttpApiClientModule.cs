using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PageService;

[DependsOn(
    typeof(PageServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class PageServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(PageServiceApplicationContractsModule).Assembly,
            PageServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PageServiceHttpApiClientModule>();
        });

    }
}
