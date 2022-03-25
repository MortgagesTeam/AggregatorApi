using AggregatorApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AggregatorApi.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        public ProductService(
           IOptions<AggregatorDbSettings> dbSettings)
        {
            var mongoClient = new MongoClient(
                dbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                dbSettings.Value.DatabaseName);

            _productCollection = mongoDatabase.GetCollection<Product>(
                dbSettings.Value.ProductCollectionName);
        }

        public async Task<List<Product>> GetAsync() =>
           await _productCollection.Find(_ => true).ToListAsync();

        public async Task<Product?> GetAsync(string productId) =>
            await _productCollection.Find(x => x.ProductId == productId).FirstOrDefaultAsync();

        public async Task CreateAsync(Product newProduct) =>
            await _productCollection.InsertOneAsync(newProduct);

        public async Task UpdateAsync(string productId, Product updatedProduct) =>
            await _productCollection.ReplaceOneAsync(x => x.ProductId == productId, updatedProduct);

        public async Task RemoveAsync(string productId) =>
            await _productCollection.DeleteOneAsync(x => x.ProductId == productId);
    }
}
