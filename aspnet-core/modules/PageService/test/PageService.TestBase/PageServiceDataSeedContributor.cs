using PageService.Pages;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace PageService;

public class PageServiceDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IGuidGenerator _guidGenerator;
    private readonly ICurrentTenant _currentTenant;
    private readonly IPageRepository _pageRepository;

    public PageServiceDataSeedContributor(
        IGuidGenerator guidGenerator, ICurrentTenant currentTenant, IPageRepository pageRepository)
    {
        _guidGenerator = guidGenerator;
        _currentTenant = currentTenant;
        _pageRepository = pageRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        await _pageRepository.InsertAsync(new Page()
        {
            Title = "Test 1",
            Slug = "test",
            IsHomePage = false,
            Content = "content"
        });
    }
}
