using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PageService.EntityFrameworkCore;

[DependsOn(
    typeof(PageServiceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class PageServiceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //Configure<AbpDbConnectionOptions>(options =>
        //{
        //    options.ConnectionStrings.Default = "Server=172.18.112.1,1433;User Id=default_sys;Password=pass;Database=CMSDB;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False"
        //});

        context.Services.AddAbpDbContext<PageServiceDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
