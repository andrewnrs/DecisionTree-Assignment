using System.Threading.Tasks;

namespace DecisionTree.CMS.Data;

public interface ICMSDbSchemaMigrator
{
    Task MigrateAsync();
}
