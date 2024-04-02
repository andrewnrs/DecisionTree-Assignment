using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace PageService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PageServiceDomainSharedModule)
)]
public class PageServiceDomainModule : AbpModule
{

}
