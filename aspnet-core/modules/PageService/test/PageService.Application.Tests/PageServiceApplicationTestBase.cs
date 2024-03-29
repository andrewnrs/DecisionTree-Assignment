using Volo.Abp.Modularity;

namespace PageService;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class PageServiceApplicationTestBase<TStartupModule> : PageServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
