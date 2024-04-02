using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PageService.EntityFrameworkCore;

[ConnectionStringName(PageServiceDbProperties.ConnectionStringName)]
public interface IPageServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
