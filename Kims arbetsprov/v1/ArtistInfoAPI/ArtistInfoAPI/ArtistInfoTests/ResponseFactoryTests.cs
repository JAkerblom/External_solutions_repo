using ArtistInfoLib;
using NUnit.Framework;

namespace ArtistInfoTests
{
    [TestFixture]
    public class ResponseFactoryTests
    {
        private ResponseFactory _responseFactory = new ResponseFactory();
        private string _jsonWithUnsuccessfulResponse = "Response status code does not indicate success: 404";

        [Test]
        public void ConvertJsonToMusicBrainzModel_Should_Return_Model_If_Unsuccessful_Json()
        {
            var model = _responseFactory.ConvertJsonToMusicBrainzModel(_jsonWithUnsuccessfulResponse);
            Assert.NotNull(model);
        }
    }
}
