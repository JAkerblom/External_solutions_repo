namespace ArtistInfoLib.Models
{
    public class Request : IRequest
    {
        public string Url { get; set; }
        public string Path { get; set; }

        public string GetUrl()
        {
            return Url;
        }

        public string GetPath()
        {
            return Path;
        }
    }
}