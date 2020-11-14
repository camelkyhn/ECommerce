using ECommerce.Middleware.Extensions;
using ECommerce.Middleware.System;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Storage
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region To Table

            builder.ToCoreTables();

            builder.ToIdentityTables();

            #endregion

            #region Relations

            builder.AddCoreRelations();

            builder.AddIdentityRelations();

            builder.AddUpdatedUserRelations();

            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(EnvironmentVariable.DbConnectionString);
            }
        }
    }
}