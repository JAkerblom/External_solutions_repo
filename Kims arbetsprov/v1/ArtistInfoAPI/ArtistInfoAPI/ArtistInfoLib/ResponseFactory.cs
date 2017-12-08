using ArtistInfoLib.Helpers;
using ArtistInfoLib.Models;
using Newtonsoft.Json;

namespace ArtistInfoLib
{
    public class ResponseFactory : IResponseFactory
    {
        public string GetErrorResponse()
        {
            return "This is an error";
        }
        public MusicBrainzModel ConvertJsonToMusicBrainzModel(string json)
        {
            if (json.Contains(GetErrorResponse()))
            {
                return new MusicBrainzModel(){id = "Mbid not found.", name = "Artist not found.", relations = new Relation[]{new Relation(){type = "wikipedia", url = new Url(){resource = "wiki/Resource not found,"}}}, releasegroups = new ReleaseGroups[]{new ReleaseGroups(){id = "Id not found."}}};
            }
            return JsonConvert.DeserializeObject<MusicBrainzModel>(json);
        }

        public WikipediaModel ConvertJsonToWikipediaModel(string json)
        {
            if (json.Contains(GetErrorResponse()))
            {
                return new WikipediaModel(){Description = "Description not found."};
            }
            var extract = json.SubstringAfter("extract").SubstringBefore("}").SubstringAfter(":");
            return new WikipediaModel {Description = extract};
        }

        public CoverArtArchiveModel ConvertJsonToCoverArtArchiveModel(string json)
        {
            if (json.Contains(GetErrorResponse()))
            {
                return new CoverArtArchiveModel(){images = new Image[]{new Image(){image = "Image not found."}}};
            }
            return JsonConvert.DeserializeObject<CoverArtArchiveModel>(json);
        }
    }
}