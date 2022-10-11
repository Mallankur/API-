using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TV_web_API.Model
{
    [BsonNoId]
    [BsonIgnoreExtraElements]
    public class tvsChannelcs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        [BsonElement("id")]
        public int id { get; set; }
        [BsonElement("url")]
        public string Url { get; set; }
        [BsonElement("name")]
        public string  name { get; set; }
        [BsonElement("type")]
        public string type  { get; set; }
        [BsonElement("language")]
        public string language { get; set; }

        public List<string> genres { get; set; }

        public string  Status { get; set; }

        public int runtime { get; set; }

        public string Premiered { get; set; }

        public string officalSite { get; set; }

        public schedule scheduletime { get; set; }

        public rating tvrating { get; set; }
        public int weight { get; set; }

        public network Mynetwork { get; set; }
        public string webChannel { get; set; }

        public externals MyRating { get; set; }

        public image Myimage { get; set; }

        public string summary { get; set; }

        public int updated { get; set; }

        public _links link { get; set; } 


    }

    public class _links
    {
        public self myself { get; set; }
        public previousepisode MyProperty { get; set; }

    }

    public class previousepisode
    {
        public string href { get; set; }

    }

    public class self
    {
        public string href { get; set; }

    }

    public class image
    {
        public string medium { get; set; }
        public int  original { get; set; }
    }

    public class externals
    {
        public int tvrage { get; set; }

        public int thetvdb { get; set; }

        public string imdb { get; set; }

    }

    public class network
    {
        public int id { get; set; }
        public string name { get; set; }
        public country mycountry { get; set; }
    }

    public class country
    {
        public string name { get; set; }
        public int code { get; set; }
        public int timezone { get; set; }
    }

    public class rating
    {
        public int average { get; set; }


    }

    public class schedule
    {
        public string time { get; set; }

        public List<string> days { get; set; }

    }
}
