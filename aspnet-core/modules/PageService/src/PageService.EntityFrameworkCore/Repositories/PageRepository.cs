using PageService.EntityFrameworkCore;
using PageService.Pages;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PageService.Repositories
{
    public class EfCorePageRepository(IDbContextProvider<PageServiceDbContext> dbContextProvider)
        : EfCoreRepository<PageServiceDbContext, Page, Guid>(dbContextProvider), IPageRepository
    {
    }
}
