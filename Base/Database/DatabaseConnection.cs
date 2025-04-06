using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Database
{
    public abstract class DatabaseConnection
    {
        protected readonly IConfiguration _configuration;

        protected DatabaseConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public abstract void Configure(IServiceCollection services);
    }
}
