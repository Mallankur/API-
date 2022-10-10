using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Playlist_api.Model
{
    [BsonIgnoreExtraElements]
    public class Playlist
    {


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string username { get; set; }
        [BsonElement("items")]
        [JsonPropertyName("items")]
        public List<string> movieid { get; set; }

    }
}
