using ArtistInfoAPI.Repositories;
using ArtistInfoLib;
using ArtistInfoLib.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace ArtistInfoAPI.Configuration
{
    public class StartupConfigurationService : IStartupConfigurationService
    {
        private IConfigurationRoot Configuration { get; set; }
        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArtistInfo V1"); });
        }

        public virtual void ConfigureEnvironment(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public virtual void ConfigureService(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<IArtistInfoRepository, ArtistInfoRepository>();
            services.AddSingleton<IRequestFactory, RequestFactory>();
            services.AddSingleton<IResponseFactory, ResponseFactory>();
            services.AddSingleton<IRequestRepository, RequestRepository>();
            services.AddSingleton<IRequestHandler, RequestHandler>();

            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1",
                        new Info {Title = "ArtistInfo API", Version = "v1", Description = GetApiDescription()});
                });
        }


        private string GetApiDescription()
        {
            return "This API gives you information about a band or artist by combining information obtained by the use of external sources. These sources include Music Brainz, Wikipedia and Cover Art Archive. <br /><br />Please note that we currently can't provide you with information about any band or artist but Nirvana. <br />But hey, they're pretty great so enjoy!";
        }
    }
}
