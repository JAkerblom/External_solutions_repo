using ArtistInfoLib.Models;

namespace ArtistInfoLib
{
    public interface IResponseFactory
    {
        MusicBrainzModel ConvertJsonToMusicBrainzModel(string json);
        WikipediaModel ConvertJsonToWikipediaModel(string json);
        CoverArtArchiveModel ConvertJsonToCoverArtArchiveModel(string json);
        string GetErrorResponse();
       // string GetErrorReponse(string source);
    }
}
