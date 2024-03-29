using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Modularity;
using Xunit;

namespace PageService.Samples;

public abstract class PageAppService_Tests<TStartupModule> : PageServiceApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IPageAppService _sampleAppService;

    protected PageAppService_Tests()
    {
        _sampleAppService = GetRequiredService<IPageAppService>();
    }

    [Fact]
    public async Task GetAsync()
    {
        var result = await _sampleAppService.GetContentBySlugAsync("");
        result.Content.ShouldBe("<h1>We are awesome!</h1>");
    }

    //[Fact]
    //public async Task GetAuthorizedAsync()
    //{
    //    var result = await _sampleAppService.GetAuthorizedAsync();
    //    result.Title.ShouldBe("Test");
    //}
}
