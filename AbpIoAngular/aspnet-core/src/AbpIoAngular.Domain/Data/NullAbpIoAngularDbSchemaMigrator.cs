using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpIoAngular.Data
{
    /* This is used if database provider does't define
     * IAbpIoAngularDbSchemaMigrator implementation.
     */
    public class NullAbpIoAngularDbSchemaMigrator : IAbpIoAngularDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}