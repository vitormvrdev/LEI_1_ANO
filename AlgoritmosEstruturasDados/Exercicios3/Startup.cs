using Refit;

namespace Exercicios3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMyApiService>(provider => RestService.For<IMyApiService>("https://localhost:5001"));
        }
    }
}
