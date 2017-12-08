using ArtistInfoAPI.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ArtistInfoAPI
{
    public class Startup
    {
        private readonly IStartupConfigurationService _externalStartupConfiguration;

        public Startup(IHostingEnvironment env, IStartupConfigurationService externalStartupConfiguration)
        {
            _externalStartupConfiguration = externalStartupConfiguration;
            _externalStartupConfiguration.ConfigureEnvironment(env);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            _externalStartupConfiguration.ConfigureService(services, null);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            _externalStartupConfiguration.Configure(app, env, loggerFactory);
            app.UseMvc();
        }
    }
}