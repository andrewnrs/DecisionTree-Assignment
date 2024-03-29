using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace PageService;

[DependsOn(
    typeof(PageServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class PageServiceApplicationContractsModule : AbpModule
{

}
