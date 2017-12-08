using ArtistInfoLib.Models;
using ArtistInfoLib.Repositories;

namespace ArtistInfoAPI.Repositories
{
    public class ArtistInfoRepository : IArtistInfoRepository
    {
        private readonly IRequestRepository _requestRepository;
        public ArtistInfoRepository(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }
   
        public IResponse GetArtistInfoModel(string id)
        {
            return _requestRepository.GetArtistInfoModel(id);
        }
    }
}