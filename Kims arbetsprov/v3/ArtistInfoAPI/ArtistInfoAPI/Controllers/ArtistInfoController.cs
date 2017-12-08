using ArtistInfoAPI.Repositories;
using ArtistInfoLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArtistInfoAPI.Controllers
{
    [Route("api/[controller]")]
    public class ArtistInfoController : Controller
    {
        private readonly IArtistInfoRepository _artistInfoRepository;

        public ArtistInfoController(IArtistInfoRepository artistInfoRepository)
        {
            _artistInfoRepository = artistInfoRepository;
        }

        [HttpGet("{mbid}")]
        [ProducesResponseType(typeof(ArtistInfoModel), 200)]
        public IActionResult GetArtistInfo(string mbid)
        {
            var artistInfo = _artistInfoRepository.GetArtistInfoModel(mbid);
            if (artistInfo == null)
            {
                return NotFound();
            }
            return Ok(artistInfo);
        }
    }
}
