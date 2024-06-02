using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace UserApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("FirstName")]
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; } = null!;

        [BsonElement("LastName")]
        [JsonPropertyName("LastName")]
        public string LastName { get; set; } = null!;

        [BsonElement("Address")]
        [JsonPropertyName("Address")]
        public string Address { get; set; } = null!;

        [BsonElement("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; } = null!;

        [BsonElement("Location")]
        [JsonPropertyName("Location")]
        public string Location { get; set; } = null!;
    }
}
