using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace PageService.Samples;

public interface IPageAppService : IApplicationService
{
    Task<PageResponseDto> CreatePageAsync(CreatePageDto page);


    Task<List<PageDto>> GetAllAsync();
    Task<PageDto> GetPageBySlugAsync(string slug);
    Task<PageContentDto> GetContentBySlugAsync(string slug);
    Task<PageDto> UpdatePageAsync(PageDto page);
    //Task<PageDto> GetHomePageAsync();
}
