using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TAT.Ecommerce.Infrastructure.Persistence.EF
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {

            string connectionString = "Data Source=trantheanh.duckdns.org,1433; Initial Catalog=TAT_EcommerceDB;User ID=tester;Password=Admin@123; TrustServerCertificate=true";

            DbContextOptionsBuilder<AppDbContext> optionsBuilder = new();
            _ = optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }

    }
}
