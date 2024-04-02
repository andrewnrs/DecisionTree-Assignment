using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace PageService.Samples;

public interface IPageAppService : IApplicationService
{
    Task<PageResponseDto> CreatePageAsync(CreatePageDto page);
    Task<List<PageResponseDto>> GetAllAsync(int skipCount, int maxResultCount);
    Task<PageContentDto> GetContentAsync(Guid id);

    Task<PageDto> UpdatePageAsync(Guid id, PageDto page);
}
