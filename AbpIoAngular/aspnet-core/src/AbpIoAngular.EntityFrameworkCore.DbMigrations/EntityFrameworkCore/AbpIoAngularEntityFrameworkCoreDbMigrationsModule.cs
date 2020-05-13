using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpIoAngular.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpIoAngularEntityFrameworkCoreModule)
        )]
    public class AbpIoAngularEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpIoAngularMigrationsDbContext>();
        }
    }
}
