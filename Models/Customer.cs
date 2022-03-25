using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AggregatorApi.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; }=null!;
        public string DateOfBirth { get; set; }= null!;
        public string Email { get; set; } = null!;
    }
}
