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

    public async Task<PageContentDto> GetContentAsync(Guid id)
    {
        var page = await pageRepository.GetAsync(id);
        return new PageContentDto(page.Content);
    }

    public Task<PageDto> UpdatePageAsync(Guid id, PageDto page)
    {
        throw new NotImplementedException();
    }
}
