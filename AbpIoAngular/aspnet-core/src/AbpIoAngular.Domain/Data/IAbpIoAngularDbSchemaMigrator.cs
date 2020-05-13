using System.Threading.Tasks;

namespace AbpIoAngular.Data
{
    public interface IAbpIoAngularDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
