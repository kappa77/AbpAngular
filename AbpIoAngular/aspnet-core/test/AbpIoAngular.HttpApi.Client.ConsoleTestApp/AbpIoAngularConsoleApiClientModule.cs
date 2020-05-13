using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpIoAngular.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpIoAngularHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpIoAngularConsoleApiClientModule : AbpModule
    {
        
    }
}
