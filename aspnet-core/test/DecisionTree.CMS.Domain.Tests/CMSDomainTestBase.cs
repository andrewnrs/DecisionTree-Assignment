using Volo.Abp.Modularity;

namespace DecisionTree.CMS;

/* Inherit from this class for your domain layer tests. */
public abstract class CMSDomainTestBase<TStartupModule> : CMSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
