using System.Linq;
using ArtistInfoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArtistInfoTest.UnitTests
{
    [TestClass]
    public class ResponseFactoryTests
    {
        private readonly ResponseFactory _responseFactory = new ResponseFactory();

        [TestMethod]
        public void GetErrorResponse_For_Wikipedia_Should_Return_Not_Empty_Model()
        {
            var json = _responseFactory.GetErrorResponse();
            var model = _responseFactory.ConvertJsonToWikipediaModel(json);
            Assert.IsNotNull(model.Description);
        }

        [TestMethod]
        public void GetErrorResponse_For_CoverArtArchive_Should_Return_Not_Empty_Model()
        {
            var json = _responseFactory.GetErrorResponse();
            var model = _responseFactory.ConvertJsonToCoverArtArchiveModel(json);
            Assert.IsNotNull(model.images.FirstOrDefault().image);
        }

        [TestMethod]
        public void GetErrorResponse_For_MusicBrainz_Should_Return_Not_Empty_Model()
        {
            var json = _responseFactory.GetErrorResponse();
            var model = _responseFactory.ConvertJsonToMusicBrainzModel(json);
            Assert.IsNotNull(model.id);
            Assert.IsNotNull(model.relations.FirstOrDefault().type);
            Assert.IsNotNull(model.relations.FirstOrDefault().url.resource);
            Assert.IsNotNull(model.releasegroups.FirstOrDefault().id);
        }
    }
}
