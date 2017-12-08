using ArtistInfoLib.Models;

namespace ArtistInfoLib
{
    public class RequestFactory : IRequestFactory
    {
        public IRequest GetRequestStrings(string source, string id)
        {
            if (source == "musicBrainz")
                return new Request
                {
                    Url = "http://musicbrainz.org",
                    Path = "/ws/2/artist/" + id + "?inc=url-rels+release-groups&fmt=json"
                };
            if (source == "wikipedia")
                return new Request
                {
                    Url = "https://en.wikipedia.org",
                    Path = "/w/api.php?action=query&format=json&prop=extracts&exintro=true&redirects=true&titles=" + id
                };
            if (source == "coverArtArchive")
                return new Request
                {
                    Url = "http://coverartarchive.org",
                    Path = "/release-group/" + id
                };
            return new Request();
        }
    }
}