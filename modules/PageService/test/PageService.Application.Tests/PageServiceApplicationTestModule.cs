using Volo.Abp.Modularity;

namespace PageService;

[DependsOn(
    typeof(PageServiceApplicationModule),
    typeof(PageServiceDomainTestModule)
    )]
public class PageServiceApplicationTestModule : AbpModule
{

}
