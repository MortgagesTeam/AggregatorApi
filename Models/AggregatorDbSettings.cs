using AggregatorApi.Models;


namespace AggregatorApi.Models
{
    public class AggregatorDbSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string CustomerCollectionName { get; set; } = null!;

        public string ProductCollectionName { get; set; } = null!;
    }
}
