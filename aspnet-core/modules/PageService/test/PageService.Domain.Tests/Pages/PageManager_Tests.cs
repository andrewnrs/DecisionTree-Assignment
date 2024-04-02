using PageService.Pages;
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace PageService.Samples;

public abstract class PageManager_Tests<TStartupModule> : PageServiceDomainTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IPageRepository pageRepository;

    public PageManager_Tests()
    {
        pageRepository = GetRequiredService<IPageRepository>();
    }

    [Fact]
    public async Task LoadRepositoryAsync()
    {
        var p = await pageRepository.GetListAsync();
        p.ShouldNotBeEmpty();
    }
}
