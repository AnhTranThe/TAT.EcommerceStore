using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TAT.Ecommerce.Infrastructure.Persistence.EF;

namespace TAT.Ecommerce.Infrastructure.DI
{
    public static class DIConfiguration
    {

        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("TAT_EcommerceDB");
            if (!string.IsNullOrEmpty(connectionString))
            {
                _ = services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString)
            );
            }


            return services;
        }

    }
}
