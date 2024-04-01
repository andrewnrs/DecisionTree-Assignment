using Microsoft.EntityFrameworkCore;
using PageService.Pages;
using Volo.Abp;

namespace PageService.EntityFrameworkCore;

public static class PageServiceDbContextModelCreatingExtensions
{
    public static void ConfigurePageService(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Page>(b =>
        {
            b.ToTable(PageServiceDbProperties.DbTablePrefix + nameof(Page), "Pages");

            /* Configure all entities here. Example:
            //b.ConfigureByConvention();
            //Properties
            //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
            //Relations
            //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);
            */

            //Indexes
            b.HasIndex(q => q.CreationTime);
            b.HasIndex(q => q.Slug);
        });
    }
}
