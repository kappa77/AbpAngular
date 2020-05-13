using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpIoAngular.EntityFrameworkCore
{
    public static class AbpIoAngularDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpIoAngular(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpIoAngularConsts.DbTablePrefix + "YourEntities", AbpIoAngularConsts.DbSchema);

            //    //...
            //});
        }
    }
}