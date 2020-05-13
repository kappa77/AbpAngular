using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpIoAngular.Data;
using Volo.Abp.DependencyInjection;

namespace AbpIoAngular.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpIoAngularDbSchemaMigrator
        : IAbpIoAngularDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpIoAngularDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpIoAngularMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpIoAngularMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}