using ArtistInfoLib.Models;

namespace ArtistInfoLib
{
    public interface IRequestHandler
    {
        string SendRequest(IRequest request);
    }
}
