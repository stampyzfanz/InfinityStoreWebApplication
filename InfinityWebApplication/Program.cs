using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using InfinityWebApplication.Data;
using Microsoft.Extensions.DependencyInjection;

namespace InfinityWebApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IHost webHost = CreateHostBuilder(args).Build();

            // Create a new scope to access services
            using (var scope = webHost.Services.CreateScope())
            {
                // Get the database instance so that the data can be seeded on program load
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                await context.SeedLargeData();
            }

            // Run the WebHost, and start accepting HTTP requests
            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
