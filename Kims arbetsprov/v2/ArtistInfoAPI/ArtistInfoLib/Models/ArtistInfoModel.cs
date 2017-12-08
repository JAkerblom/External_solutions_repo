using System.Collections.Generic;

namespace ArtistInfoLib.Models
{
    public class ArtistInfoModel : IResponse
    {
        public string Artist { get; set; }

        public string Description { get; set; }
        public string Mbid { get; set; }

        public List<Album> Albums { get; set; }
    }
}
