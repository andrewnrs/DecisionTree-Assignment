using PageService.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageService.Samples;

public class PageAppService(
    IPageRepository pageRepository
    ) : PageServiceAppService, IPageAppService
{
    private readonly IPageRepository pageRepository = pageRepository;

    public async Task<PageResponseDto> CreatePageAsync(CreatePageDto input)
    {
        Page? page;

        if (input.Id.Equals(Guid.Empty))
        {
            page = ObjectMapper.Map<CreatePageDto, Page>(input);
            page = await pageRepository.InsertAsync(page);
        }
        else
        {
            page = await pageRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, page);
            page = await pageRepository.UpdateAsync(page);
        }

        return ObjectMapper.Map<Page, PageResponseDto>(page);
    }

    public async Task<List<PageResponseDto>> GetAllAsync(int skipCount, int maxResultCount)
    {
        var pagedEntities = await pageRepository.GetPagedListAsync(skipCount, maxResultCount, "");
        return ObjectMapper.Map<List<Page>, List<PageResponseDto>>(pagedEntities);
    }

    public Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return Task.FromResult(
            PageDto.HomePage()
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

}
