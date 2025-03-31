using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCalendar.Application.Interfaces.Services;
using MyCalendar.Application.Services;

namespace MyCalendar.Application
{
    public static class DependencyEjection
    {
        public static IServiceCollection AddScopedConfig(this IServiceCollection serices, IConfiguration configuration)
        {
            serices.AddScoped<IUserService, UserService>();
            return serices;
        }
    }
}
