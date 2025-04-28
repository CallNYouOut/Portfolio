using Microsoft.EntityFrameworkCore;
using CGaffney206Lab5.Models;
using Packt.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace CGaffney206Lab5.Models
{
    public static class SportsLeaguesContextExtension
    {
        public static IServiceCollection AddSportsLeaguesContext(
            this IServiceCollection services, string connectionString =
            "Data Source=COLIN-GOODPC\\SQLEXPRESS;Initial Catalog=SportsLeagues;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
        {
            services.AddDbContext<SportsLeaguesContext>(options =>
            options.UseSqlServer(connectionString)
            .UseLoggerFactory(new ConsoleLoggerFactory())
            );

            return services;
        }
    }
}
