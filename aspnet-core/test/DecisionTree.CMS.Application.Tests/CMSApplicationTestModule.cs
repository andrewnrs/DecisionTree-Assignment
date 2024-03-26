using Volo.Abp.Modularity;

namespace DecisionTree.CMS;

[DependsOn(
    typeof(CMSApplicationModule),
    typeof(CMSDomainTestModule)
)]
public class CMSApplicationTestModule : AbpModule
{

}
