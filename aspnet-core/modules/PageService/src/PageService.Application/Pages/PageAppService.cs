using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PageService.Samples;

public class PageAppService : PageServiceAppService, IPageAppService
{
    public Task<PageDto> GetAsync()
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }

    //[Authorize]
    public Task<List<PageDto>> GetAllAsync()
    {
        return Task.FromResult(
            new List<PageDto>() {
                PageDto.HomePage(),
                PageDto.AboutUs()
            }
        );
    }

    public Task<PageDto> GetPageBySlugAsync(string slug)
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }

    public Task<PageContentDto> GetContentBySlugAsync(string slug)
    {
        return Task.FromResult(
            new PageContentDto(PageDto.AboutUs().Content)
        );
    }

    public Task<PageDto> CreatePageAsync(PageDto page)
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }

    public Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }
}
