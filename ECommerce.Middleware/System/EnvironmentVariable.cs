using ECommerce.Middleware.Exceptions;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Middleware.System
{
    public class EnvironmentVariable
    {
        public static IConfiguration Configuration { get; set; }

        private static void ConfigurationSetupIfNull()
        {
            if (Configuration == null)
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                Configuration = builder.Build();
            }
        }

        public static string DbConnectionString
        {
            get
            {
                ConfigurationSetupIfNull();
                var dbConnectionString = Configuration["Configuration:DB_CONNECTION_STRING"];
                if (dbConnectionString == null)
                {
                    throw new EnvironmentVariableException("DB_CONNECTION_STRING");
                }

                return dbConnectionString;
            }
        }
    }
}