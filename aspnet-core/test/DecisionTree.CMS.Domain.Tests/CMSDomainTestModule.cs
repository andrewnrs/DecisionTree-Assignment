using Volo.Abp.Modularity;

namespace DecisionTree.CMS;

[DependsOn(
    typeof(CMSDomainModule),
    typeof(CMSTestBaseModule)
)]
public class CMSDomainTestModule : AbpModule
{

}
