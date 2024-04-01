using PageService.Pages;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.ObjectMapping;

namespace PageService.Samples;

public class PageAppService(
    IPageRepository pageRepository
        //, IObjectMapper<PageServiceAppService> objectMapper
    ) : PageServiceAppService, IPageAppService
{
    private readonly IPageRepository pageRepository = pageRepository;
    //private readonly IObjectMapper<PageServiceAppService> objectMapper = objectMapper;

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

    //public async Task<PageResponseDto> CreatePageAsync(PageDto page)
    //{
        //var pageEntity = Page.From(ObjectMapper.Map<PageDto, PageVo>(page));
        //var createdEntity = await pageRepository.InsertAsync(pageEntity);
        //return ObjectMapper.Map<Page, PageResponseDto>(createdEntity);
    //}

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

    public Task<PageDto> UpdatePageAsync(PageDto page)
    {
        return Task.FromResult(
            PageDto.HomePage()
        );
    }
}
