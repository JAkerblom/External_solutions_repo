using ArtistInfoAPI.Repositories;
using ArtistInfoLib;
using ArtistInfoLib.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ArtistInfoAPI.Configuration
{
    public class TestStartupConfigurationService : IStartupConfigurationService
    {
        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
        }

        public virtual void ConfigureEnvironment(IHostingEnvironment env)
        {
            env.EnvironmentName = "Test";
        }

        public virtual void ConfigureService(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<IArtistInfoRepository, ArtistInfoRepository>();
            services.AddSingleton<IRequestFactory, RequestFactory>();
            services.AddSingleton<IResponseFactory, ResponseFactory>();
            services.AddSingleton<IRequestRepository, RequestRepository>();
            services.AddSingleton<IRequestHandler, RequestHandler>();
        }
    }
}
