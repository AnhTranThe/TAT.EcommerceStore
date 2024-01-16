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

            _ = services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TAT_EcommerceDB"))
            );

            return services;
        }

    }
}
