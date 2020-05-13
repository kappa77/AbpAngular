using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpIoAngular.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpIoAngularMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpIoAngularMigrationsDbContext>
    {
        public AbpIoAngularMigrationsDbContext CreateDbContext(string[] args)
        {
            AbpIoAngularEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpIoAngularMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpIoAngularMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
