using MyApp.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Logic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            // Registratie van services
            services.AddScoped<ProductService>();
            return services;
        }
    }
}
