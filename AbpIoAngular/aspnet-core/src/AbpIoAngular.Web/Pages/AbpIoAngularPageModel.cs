using AbpIoAngular.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpIoAngular.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpIoAngularPageModel : AbpPageModel
    {
        protected AbpIoAngularPageModel()
        {
            LocalizationResourceType = typeof(AbpIoAngularResource);
        }
    }
}