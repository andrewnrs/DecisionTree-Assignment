using Volo.Abp.Modularity;

namespace PageService;

[DependsOn(
    typeof(PageServiceDomainModule),
    typeof(PageServiceTestBaseModule)
)]
public class PageServiceDomainTestModule : AbpModule
{

}
