using Microsoft.EntityFrameworkCore;
using PageService.Pages;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PageService.EntityFrameworkCore;

[ConnectionStringName(PageServiceDbProperties.ConnectionStringName)]
public class PageServiceDbContext(DbContextOptions<PageServiceDbContext> options) : AbpDbContext<PageServiceDbContext>(options), IPageServiceDbContext
{
    private static string TablePrefix { get; set; } = AbpDbConsts.DefaultDbTablePrefix;

    public DbSet<Page> Pages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePageService();
    }
}
