using ArtistInfoLib.Models;

namespace ArtistInfoLib
{
    public interface IRequestFactory
    {
        IRequest GetRequestStrings(string source, string id);
    }
}
