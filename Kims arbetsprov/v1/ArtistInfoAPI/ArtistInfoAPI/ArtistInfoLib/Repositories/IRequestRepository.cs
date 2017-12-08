using ArtistInfoLib.Models;

namespace ArtistInfoLib.Repositories
{
    public interface IRequestRepository
    {
        IResponse GetArtistInfoModel(string mbid);
    }
}
