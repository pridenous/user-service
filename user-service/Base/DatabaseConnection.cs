namespace user_service.Base
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
