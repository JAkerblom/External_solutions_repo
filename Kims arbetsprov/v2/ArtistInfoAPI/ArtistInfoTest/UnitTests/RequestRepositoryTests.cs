using ArtistInfoLib;
using ArtistInfoLib.Models;
using ArtistInfoLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ArtistInfoTest.UnitTests
{
    [TestClass]
    public class RequestRepositoryTests
    {
        private IRequestRepository _requestRepository;

        private void Setup()
        {
            var mockRequestFactory = new Mock<IRequestFactory>();
            var mockResponseFactory = new Mock<IResponseFactory>();
            var mockRequestHandler = new Mock<IRequestHandler>();
            
            mockRequestFactory.Setup(x => x.GetRequestStrings(It.IsAny<string>(), It.IsAny<string>())).Returns(new Request());
            mockRequestHandler.Setup(x => x.SendRequest(It.IsAny<IRequest>())).Returns("json");
            mockResponseFactory.Setup(x => x.ConvertJsonToWikipediaModel(It.IsAny<string>()))
                .Returns(GetMockWikipediaModel());
            mockResponseFactory.Setup(x => x.ConvertJsonToCoverArtArchiveModel(It.IsAny<string>()))
                .Returns(GetMockCoverArtArchiveModel);
            mockResponseFactory.Setup(x => x.ConvertJsonToMusicBrainzModel(It.IsAny<string>()))
                .Returns(GetMockMusicBrainzModel);

            _requestRepository = new RequestRepository(mockRequestFactory.Object, mockResponseFactory.Object, mockRequestHandler.Object);
        }

        private MusicBrainzModel GetMockMusicBrainzModel()
        {
            return new MusicBrainzModel()
            {
                id = "Id",
                name = "Name",
                relations = new Relation[]
                    {new Relation() {type = "wikipedia", url = new Url() {resource = "wiki/WikiResource"}}},
                releasegroups = new ReleaseGroups[] {new ReleaseGroups() {id = "Id"}}
            }; 
        }

        private CoverArtArchiveModel GetMockCoverArtArchiveModel()
        {
            return new CoverArtArchiveModel(){images = new[]{new Image(){image = "ImageUrl"}}};
        }

        private WikipediaModel GetMockWikipediaModel()
        {
            return new WikipediaModel(){Description = "Description"};
        }

        [TestMethod]
        public void GetArtistInfoModel_Should_Return_Model()
        {
            Setup();
            var result = _requestRepository.GetArtistInfoModel("mbid");
            Assert.IsNotNull(result);
        }
    }
}
