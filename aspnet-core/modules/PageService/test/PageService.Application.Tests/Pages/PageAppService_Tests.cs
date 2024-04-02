using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using Shouldly;
using Volo.Abp.Modularity;
using Xunit;

namespace PageService.Samples;

public abstract class PageAppService_Tests<TStartupModule> : PageServiceApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IPageAppService _pageAppService;

    protected PageAppService_Tests()
    {
        _pageAppService = GetRequiredService<IPageAppService>();
    }

    [Theory]
    [InlineData("content")]
    public async Task GetAsync(string slug)
    {
        var result = await _pageAppService.GetAllAsync(0, 1);

        result.ShouldNotBeEmpty();
        result.First().Content.ShouldBe(slug);
    }

    [Theory]
    [InlineData("testing")]
    public async Task UpdateAsync(string newSlug)
    {
        var allPages = await _pageAppService.GetAllAsync(0, 1);
        var myPage = allPages.First();

        var result = await _pageAppService.CreatePageAsync(
            new CreatePageDto(
                myPage.Title,
                newSlug,
                myPage.Content,
                myPage.IsHomePage
            ));

        result.ShouldNotBeNull();
        result.Slug.ShouldBe(newSlug);
    }

    [Theory]
    [InlineData(["title","test","content",true])]
    public async Task PostAsync(string title, string slug, string content, bool isHomePage)
    {
        var result = await _pageAppService.CreatePageAsync(
            new CreatePageDto(
                title,
                slug,
                content,
                isHomePage
            ));

        result.ShouldNotBeNull();
        result.Title.ShouldBe(title);
    }
}
