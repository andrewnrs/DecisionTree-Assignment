﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace PageService.Samples;

[Area(PageServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = PageServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/page-service/pages")]
public class PageController(IPageAppService pageAppService) : PageServiceController
{
    private readonly IPageAppService _pageAppService = pageAppService;

    [Authorize]
    [HttpGet]
    public async Task<List<PageResponseDto>> GetAllAsync([FromQuery]int skipCount = 0, [FromQuery] int maxResultCount = 50)
    {
        return await _pageAppService.GetAllAsync(skipCount, maxResultCount);
    }

    [Authorize]
    [HttpPost]
    public async Task<PageResponseDto> CreatePageAsync(CreatePageDto page)
    {
        return await _pageAppService.CreatePageAsync(page);
    }

    [Authorize]
    [HttpGet("{id}/content")]
    public async Task<PageContentDto> GetContentAsync(Guid id)
    {
        return await _pageAppService.GetContentAsync(id);
    }

    [Obsolete("Implemented on POST /pages")]
    [HttpPut("{id}")]
    public Task<PageDto> UpdatePageAsync(Guid id, PageDto page) => throw new NotImplementedException();
}
