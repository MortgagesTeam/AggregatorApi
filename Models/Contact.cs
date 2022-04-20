using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AggregatorApi.Models
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Salutations Title { get; set; } 
        public string FirstName { get; set; }=null!;
        public string SecondName { get; set; }=null!;
        public string Surname { get; set; }=null!;       
        public string Email { get; set; } = null!;
        public string ConatctNumber { get; set; } = null!;
        public string Message {get; set; }= null!; 
    }
}
