using System.Net.Http;
using ArtistInfoAPI;
using ArtistInfoAPI.Configuration;
using ArtistInfoLib.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ArtistInfoTest.IntegrationTests
{
    [TestClass]
    public class GetArtistInfoTest
    {
        private WebHostBuilder _webHostBuilder;
        private TestServer _testServer;
        private HttpClient _client;
        private string _mbid;
        private void Setup()
        {
            _webHostBuilder = new WebHostBuilder();
            _webHostBuilder.ConfigureServices(s => s.AddSingleton<IStartupConfigurationService, TestStartupConfigurationService>());
            _webHostBuilder.UseStartup<Startup>();
            _testServer = new TestServer(_webHostBuilder);
            _client = _testServer.CreateClient();
            _mbid = "5b11f4ce-a62d-471e-81fc-a69a8278c7da";
        }

        [TestMethod]
        public void GetArtistInfo_Returns_Not_Empty_Response()
        {
            Setup();
            var response = _client.GetAsync("/api/artistInfo/" + _mbid).Result;
            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            var resultObject = JsonConvert.DeserializeObject<ArtistInfoModel>(result);

            Assert.IsNotNull(resultObject.Mbid);
            Assert.IsNotNull(resultObject.Artist);
            Assert.IsNotNull(resultObject.Description);
            Assert.IsNotNull(resultObject.Albums);
        }
    }
}
