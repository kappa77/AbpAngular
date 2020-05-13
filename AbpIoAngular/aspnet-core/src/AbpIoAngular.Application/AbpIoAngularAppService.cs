using System;
using System.Collections.Generic;
using System.Text;
using AbpIoAngular.Localization;
using Volo.Abp.Application.Services;

namespace AbpIoAngular
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpIoAngularAppService : ApplicationService
    {
        protected AbpIoAngularAppService()
        {
            LocalizationResource = typeof(AbpIoAngularResource);
        }
    }
}
