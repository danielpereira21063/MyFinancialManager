using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinancialManager.Data.Context;

namespace MyFinancialManager.DI
{
    public static class DependencyInjectionApi
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.ConfigureDbContext(configuration);
            services.ConfigureSwagger();

            return services;
        }

        private static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("SqliteConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );
            return services;
        }

        private static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }
    }
}
