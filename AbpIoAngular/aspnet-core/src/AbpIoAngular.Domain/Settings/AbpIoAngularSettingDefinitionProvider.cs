using Volo.Abp.Settings;

namespace AbpIoAngular.Settings
{
    public class AbpIoAngularSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpIoAngularSettings.MySetting1));
        }
    }
}
