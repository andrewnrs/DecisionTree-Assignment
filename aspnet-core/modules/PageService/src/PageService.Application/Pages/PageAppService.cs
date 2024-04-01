using PageService.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace PageService.Samples;

public class PageAppService(
    IPageRepository pageRepository
    ) : PageServiceAppService, IPageAppService
{
    private readonly IPageRepository pageRepository = pageRepository;

    public Task<PageDto> GetAsync()
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }

    public async Task<PageResponseDto> CreatePageAsync(CreatePageDto input)
    {
        try
        {
            var createPage = ObjectMapper.Map<CreatePageDto, Page>(input);

            var pageEntity = await pageRepository.InsertAsync(createPage);

            return ObjectMapper.Map<Page, PageResponseDto>(pageEntity);

            //TODO: test exception cases
        }
        catch (Exception ex)
        {
            throw new UserFriendlyException(ex.Message);
        }
    }

    //[Authorize]
    public async Task<List<PageResponseDto>> GetAllAsync(int skipCount, int maxResultCount)
    {
        var pagedEntities = await pageRepository.GetPagedListAsync(skipCount, maxResultCount, "");
        return ObjectMapper.Map<List<Page>, List<PageResponseDto>>(pagedEntities);
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

    public Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }
}
