using DecisionTree.CMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DecisionTree.CMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CMSEntityFrameworkCoreModule),
    typeof(CMSApplicationContractsModule)
    )]
public class CMSDbMigratorModule : AbpModule
{
}
