using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extenstions
{
    public static class ApplicationServiceExtenstions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
             services.AddScoped<ITokenService, TokenService>();
             services.AddDbContext<DataContext> ( options =>
            {
                    options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}