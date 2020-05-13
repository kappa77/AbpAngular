using AbpIoAngular.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpIoAngular
{
    [DependsOn(
        typeof(AbpIoAngularEntityFrameworkCoreTestModule)
        )]
    public class AbpIoAngularDomainTestModule : AbpModule
    {

    }
}