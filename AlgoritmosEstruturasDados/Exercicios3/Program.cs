using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Exercicios3.Data;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace Exercicios3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            // Configurar a conexão com a Base de Dados
            builder.Services.AddRefitClient<IMyApiService>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri
                ("https://localhost:5001"));


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
