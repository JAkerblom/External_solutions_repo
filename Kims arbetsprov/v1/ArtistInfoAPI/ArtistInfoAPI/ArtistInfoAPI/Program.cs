using System.IO;
using ArtistInfoAPI.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ArtistInfoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .ConfigureServices(s => s.AddSingleton<IStartupConfigurationService, StartupConfigurationService>())
                .Build();

            host.Run();
        }
    }
}