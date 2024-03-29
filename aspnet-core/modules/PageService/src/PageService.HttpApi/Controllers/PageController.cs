using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace PageService.Samples;

[Area(PageServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = PageServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/page-service/pages")]
public class PageController(IPageAppService sampleAppService) : PageServiceController, IPageAppService
{
    private readonly IPageAppService _pageAppService = sampleAppService;

    //[Authorize]
    [HttpGet]
    public async Task<List<PageDto>> GetAllAsync()
    {
        return await _pageAppService.GetAllAsync();
    }

    //[Authorize]
    [HttpPost]
    public async Task<PageDto> CreatePageAsync(PageDto page)
    {
        return await _pageAppService.CreatePageAsync(page);
    }

    //[Authorize]
    [HttpGet("{slug}")]
    public async Task<PageDto> GetPageBySlugAsync(string slug)
    {
        return await _pageAppService.GetPageBySlugAsync(slug);
    }

    //[Authorize]
    [HttpGet("{slug}/content")]
    public async Task<PageContentDto> GetContentBySlugAsync(string slug)
    {
        return await _pageAppService.GetContentBySlugAsync(slug);
    }

    //[Authorize]
    //[Route("{slug}")] ?????????
    [HttpPut("{slug}")]
    public async Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return await _pageAppService.UpdatePageAsync(page);
    }
}
