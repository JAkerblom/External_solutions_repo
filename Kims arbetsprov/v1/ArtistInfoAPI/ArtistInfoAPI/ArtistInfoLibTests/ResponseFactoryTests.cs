using System;
using ArtistInfoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArtistInfoTests
{
    [TestClass]
    public class ResponseFactoryTests
    {
        private ResponseFactory _responseFactory = new ResponseFactory();
        private string _jsonWithUnsuccessfulResponse = "Response status code does not indicate success: 404";

        [TestMethod]
        public void ConvertJsonToMusicBrainzModel_Should_Return_Model_If_Unsuccessful_Json()
        {
            var model = _responseFactory.ConvertJsonToMusicBrainzModel(_jsonWithUnsuccessfulResponse);
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void ConvertJsonToWikipediaModel_Should_Return_Model_If_Unsuccessful_Json()
        {
            var model = _responseFactory.ConvertJsonToWikipediaModel(_jsonWithUnsuccessfulResponse);
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void ConvertJsonToCoverArtArchiveModel_Should_Return_Model_If_Unsuccessful_Json()
        {
            var model = _responseFactory.ConvertJsonToCoverArtArchiveModel(_jsonWithUnsuccessfulResponse);
            Assert.IsNotNull(model);
        }
    }
}
