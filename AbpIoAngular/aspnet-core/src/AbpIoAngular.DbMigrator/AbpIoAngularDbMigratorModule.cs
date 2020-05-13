using AbpIoAngular.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpIoAngular.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpIoAngularEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpIoAngularApplicationContractsModule)
        )]
    public class AbpIoAngularDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
