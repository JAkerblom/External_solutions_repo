using ArtistInfoLib.Models;

namespace ArtistInfoAPI.Repositories
{
    public interface IArtistInfoRepository
    {
        IResponse GetArtistInfoModel(string id);
    }
}
