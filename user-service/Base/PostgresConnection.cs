using Microsoft.EntityFrameworkCore;
using System;

namespace user_service.Base
{
    public class PostgresConnection : DatabaseConnection
    {
        public PostgresConnection(IConfiguration configuration) : base(configuration) { }

        public override void Configure(IServiceCollection services)
        {
            var connectionString = _configuration.GetConnectionString("Postgres");

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
