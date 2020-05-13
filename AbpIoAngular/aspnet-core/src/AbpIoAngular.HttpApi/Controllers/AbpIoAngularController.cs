using AbpIoAngular.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpIoAngular.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpIoAngularController : AbpController
    {
        protected AbpIoAngularController()
        {
            LocalizationResource = typeof(AbpIoAngularResource);
        }
    }
}