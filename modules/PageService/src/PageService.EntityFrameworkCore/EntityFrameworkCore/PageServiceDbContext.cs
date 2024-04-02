using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PageService.EntityFrameworkCore;

[ConnectionStringName(PageServiceDbProperties.ConnectionStringName)]
public class PageServiceDbContext : AbpDbContext<PageServiceDbContext>, IPageServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public PageServiceDbContext(DbContextOptions<PageServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePageService();
    }
}
