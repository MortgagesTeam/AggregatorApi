using AggregatorApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AggregatorApi.Services
{
    public class ContactService
    {
        private readonly IMongoCollection<Contact> _contactCollection;

        public ContactService(
            IOptions<AggregatorDbSettings> dbSettings)
        {
            var mongoClient = new MongoClient(
                dbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                dbSettings.Value.DatabaseName);

            _contactCollection = mongoDatabase.GetCollection<Contact>(
                dbSettings.Value.ContactCollectionName);
        }

        public async Task<List<Contact>> GetAsync() =>
            await _contactCollection.Find(_ => true).ToListAsync();

        public async Task<Contact?> GetAsync(string id) =>
           await _contactCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Contact newMessage) =>
            await _contactCollection.InsertOneAsync(newMessage);

        public async Task UpdateAsync(string id, Contact updatedMessage) =>
            await _contactCollection.ReplaceOneAsync(x => x.Id == id, updatedMessage);

        public async Task RemoveAsync(string id) =>
            await _contactCollection.DeleteOneAsync(x => x.Id == id);
    }
}
