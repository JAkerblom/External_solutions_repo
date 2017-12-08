using System.Linq;
using ArtistInfoLib.Helpers;
using Newtonsoft.Json;

namespace ArtistInfoLib.Models
{
    public class MusicBrainzModel : IResponseModel
    {
        public string[] isnis { get; set; }
        public Area area { get; set; }
        public string country { get; set; }
        public object end_area { get; set; }
        public Begin_Area begin_area { get; set; }
        public string typeid { get; set; }
        public string name { get; set; }
        public object genderid { get; set; }
        public LifeSpan lifespan { get; set; }
        public string type { get; set; }
        public object[] ipis { get; set; }

        [JsonProperty("release-groups")]
        public ReleaseGroups[] releasegroups { get; set; }

        public string id { get; set; }
        public string disambiguation { get; set; }
        public string sortname { get; set; }
        public object gender { get; set; }
        public Relation[] relations { get; set; }

        public string GetWikipediaId()
        {
            return relations.FirstOrDefault(x => x.type == "wikipedia").url.resource.SubstringAfter("wiki/");
        }
    }

    public class Area
    {
        public string[] iso31661codes { get; set; }
        public string name { get; set; }
        public string sortname { get; set; }
        public string disambiguation { get; set; }
        public string id { get; set; }
    }

    public class Begin_Area
    {
        public string sortname { get; set; }
        public string name { get; set; }
        public string disambiguation { get; set; }
        public string id { get; set; }
    }

    public class LifeSpan
    {
        public bool ended { get; set; }
        public string begin { get; set; }
        public string end { get; set; }
    }

    public class ReleaseGroups
    {
        public string firstreleasedate { get; set; }
        public string id { get; set; }
        public string[] secondarytypes { get; set; }
        public string[] secondarytypeids { get; set; }

        [JsonProperty("primary-type")]
        public string primarytype { get; set; }

        public string disambiguation { get; set; }
        public string primarytypeid { get; set; }
        public string title { get; set; }
    }

    public class Relation
    {
        public string sourcecredit { get; set; }
        public string typeid { get; set; }
        public string direction { get; set; }
        public string targetcredit { get; set; }
        public bool ended { get; set; }
        public string targettype { get; set; }
        public object begin { get; set; }
        public AttributeValues attributevalues { get; set; }
        public object[] attributes { get; set; }
        public Url url { get; set; }
        public object end { get; set; }
        public string type { get; set; }
    }

    public class AttributeValues
    {
    }

    public class Url
    {
        public string resource { get; set; }
        public string id { get; set; }
    }
}