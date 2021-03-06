using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AggregatorApi.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Salutations Title { get; set; } 
        public string FirstName { get; set; }=null!;
        public string SecondName { get; set; }=null!;
        public string Surname { get; set; }=null!;
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }=null!;
        public string Email { get; set; } = null!;
        public string ConatctNumber { get; set; } = null!;
        public string ProductId {get; set; }= null!;
        public string ProductDesc {get; set; }= null!;
        public int? LoanAmount {get; set; }= null!;
        public int? TermMonths {get; set; }= null!;
        public int? TermYear {get; set; }= null!;

        
    }
}
