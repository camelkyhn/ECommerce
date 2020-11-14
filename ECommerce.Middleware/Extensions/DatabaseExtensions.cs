using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Middleware.Extensions
{
    public static class DatabaseExtensions
    {
        public static void InitializeDatabase<TContext>(this IApplicationBuilder app) where TContext  : DbContext
        {
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<TContext>();
                context.Database.Migrate();
            }
        }
    }
}