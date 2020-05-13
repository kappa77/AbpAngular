using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AbpIoAngular.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpIoAngular.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AbpIoAngular.Web.Pages.AbpIoAngularPage
     */
    public abstract class AbpIoAngularPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpIoAngularResource> L { get; set; }
    }
}
