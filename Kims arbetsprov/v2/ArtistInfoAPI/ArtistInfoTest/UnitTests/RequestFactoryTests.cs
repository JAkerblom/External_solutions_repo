using ArtistInfoLib;
using ArtistInfoLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArtistInfoTest.UnitTests
{
    [TestClass]
    public class RequestFactoryTests
    {
        private readonly RequestFactory _requestFactory = new RequestFactory();
        private string _testId = "testId";

        [TestMethod]
        public void GetRequestStrings_Should_Return_Correct_Request_Strings_MusicBrainz()
        {
            var expected = new Request()
            {
                Url = "http://musicbrainz.org",
                Path = "/ws/2/artist/testId?inc=url-rels+release-groups&fmt=json"
            };
            var result = _requestFactory.GetRequestStrings("musicBrainz", _testId);
            Assert.AreEqual(expected.Url, result.GetUrl());
            Assert.AreEqual(expected.Path, result.GetPath());
        }

        [TestMethod]
        public void GetRequestStrings_Should_Return_Correct_Request_Strings_Wikipedia()
        {
            var expected = new Request()
            {
                Url = "https://en.wikipedia.org",
                Path = "/w/api.php?action=query&format=json&prop=extracts&exintro=true&redirects=true&titles=testId"
            };
            var result = _requestFactory.GetRequestStrings("wikipedia", _testId);
            Assert.AreEqual(expected.Url, result.GetUrl());
            Assert.AreEqual(expected.Path, result.GetPath());
        }

        [TestMethod]
        public void GetRequestStrings_Should_Return_Correct_Request_Strings_CoverArtArchive()
        {
            var expected = new Request()
            {
                Url = "http://coverartarchive.org",
                Path = "/release-group/testId"
            };
            var result = _requestFactory.GetRequestStrings("coverArtArchive", _testId);
            Assert.AreEqual(expected.Url, result.GetUrl());
            Assert.AreEqual(expected.Path, result.GetPath());
        }
    }
}
