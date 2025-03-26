using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyCalendar.Data
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddDbContextConfig(this IServiceCollection services, IConfiguration configurarion)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configurarion.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
