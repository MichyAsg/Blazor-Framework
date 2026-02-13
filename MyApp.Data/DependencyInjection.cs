using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Data.Repositories;
using MyApp.Logic.Interfaces;

namespace MyApp.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            // DbContext registreren
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Repository implementaties
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
