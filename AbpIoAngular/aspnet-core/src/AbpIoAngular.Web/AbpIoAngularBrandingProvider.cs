using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpIoAngular.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpIoAngularBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpIoAngular";
    }
}
