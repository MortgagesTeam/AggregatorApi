using AggregatorApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AggregatorApi.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customerCollection;

        public CustomerService(
            IOptions<AggregatorDbSettings> dbSettings)
        {
            var mongoClient = new MongoClient(
                dbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                dbSettings.Value.DatabaseName);

            _customerCollection = mongoDatabase.GetCollection<Customer>(
                dbSettings.Value.CustomerCollectionName);
        }

        public async Task<List<Customer>> GetAsync() =>
            await _customerCollection.Find(_ => true).ToListAsync();

        public async Task<Customer?> GetAsync(string id) =>
           await _customerCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Customer newBook) =>
            await _customerCollection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, Customer updatedBook) =>
            await _customerCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _customerCollection.DeleteOneAsync(x => x.Id == id);
    }
}
