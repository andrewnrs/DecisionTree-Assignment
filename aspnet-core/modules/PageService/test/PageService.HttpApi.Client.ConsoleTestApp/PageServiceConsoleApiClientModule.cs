using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace PageService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PageServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PageServiceConsoleApiClientModule : AbpModule
{

}
