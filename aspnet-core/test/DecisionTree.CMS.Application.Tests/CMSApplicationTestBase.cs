using Volo.Abp.Modularity;

namespace DecisionTree.CMS;

public abstract class CMSApplicationTestBase<TStartupModule> : CMSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
