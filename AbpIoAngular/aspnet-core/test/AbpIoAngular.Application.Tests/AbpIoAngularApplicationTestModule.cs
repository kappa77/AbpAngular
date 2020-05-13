using Volo.Abp.Modularity;

namespace AbpIoAngular
{
    [DependsOn(
        typeof(AbpIoAngularApplicationModule),
        typeof(AbpIoAngularDomainTestModule)
        )]
    public class AbpIoAngularApplicationTestModule : AbpModule
    {

    }
}