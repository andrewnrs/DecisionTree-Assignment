using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DecisionTree.CMS.Data;
using Volo.Abp.DependencyInjection;

namespace DecisionTree.CMS.EntityFrameworkCore;

public class EntityFrameworkCoreCMSDbSchemaMigrator
    : ICMSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCMSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CMSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CMSDbContext>()
            .Database
            .MigrateAsync();
    }
}
