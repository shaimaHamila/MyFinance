/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyFinance.Data;

namespace MyFinance.Web.Data
{
    public class SampleContextFactory: IDesignTimeDbContextFactory<MyFinanceContext>
    {
        public MyFinanceContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<MyFinanceContext>();
            var connectionString = configuration.GetConnectionString("MyFinanceDBConnection");
            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("MyFinance.Web"));

            return new MyFinanceContext(builder.Options);
        }
    }
}
*/