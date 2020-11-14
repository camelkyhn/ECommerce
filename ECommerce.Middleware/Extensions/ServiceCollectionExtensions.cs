using ECommerce.Middleware.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Middleware.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices<TContext>(this IServiceCollection services, string dbConnectionString) where TContext : DbContext
        {
            services.AddControllers();
            services.AddDbContext<TContext>(options =>
            {
                options.UseSqlite(EnvironmentVariable.DbConnectionString);
            });
        }
    }
}