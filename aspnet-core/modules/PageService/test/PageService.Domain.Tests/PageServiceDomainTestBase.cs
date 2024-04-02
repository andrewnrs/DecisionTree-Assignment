using Volo.Abp.Modularity;

namespace PageService;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class PageServiceDomainTestBase<TStartupModule> : PageServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
