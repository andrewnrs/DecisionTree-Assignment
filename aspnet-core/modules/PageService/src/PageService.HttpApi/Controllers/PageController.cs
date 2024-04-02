using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace PageService.Samples;

[Area(PageServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = PageServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/page-service/pages")]
public class PageController(IPageAppService pageAppService) : PageServiceController, IPageAppService
{
    private readonly IPageAppService _pageAppService = pageAppService;

    [Authorize]
    [HttpGet]
    public async Task<List<PageResponseDto>> GetAllAsync([FromQuery]int skipCount = 0, [FromQuery] int maxResultCount = 10)
    {
        return await _pageAppService.GetAllAsync(skipCount, maxResultCount);
    }

    //[Authorize]
    [HttpPost]
    public async Task<PageResponseDto> CreatePageAsync(CreatePageDto page)
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
    [HttpPut("{slug}")]
    public async Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return await _pageAppService.UpdatePageAsync(page);
    }
}
