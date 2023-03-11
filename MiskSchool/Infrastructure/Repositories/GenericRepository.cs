using Microsoft.Azure.Cosmos;
using MiskSchool.Infrastructure.IRepositories;

namespace InterviewTask.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IConfiguration _configuration;
        private CosmosClient _cosmosClient;
        private Database _database;
        private Container _container;

        public GenericRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _cosmosClient = new CosmosClient(_configuration.GetSection("Azure:Url").Value, _configuration.GetSection("Azure:PrimaryKey").Value);
            _database = _cosmosClient.CreateDatabaseIfNotExistsAsync("MyDatabase").GetAwaiter().GetResult();
            _container = _database.CreateContainerIfNotExistsAsync("MyContainer", "/id").GetAwaiter().GetResult();
        }
        public async Task<T> GetAsync(string id)
        {
            try
            {
                ItemResponse<T> response = await _container.ReadItemAsync<T>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return default;
            }
        }

        public async Task<List<T>> GetAsync()
        {
            var query = _container.GetItemQueryIterator<T>();
            var results = new List<T>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<T> AddAsync(T request)
        {
            var response = await _container.CreateItemAsync(request);
            return response.Resource;
        }

        public async Task<T> UpdateAsync(string id, T request)
        {
            var response = await _container.ReplaceItemAsync<T>(request, id, new PartitionKey(id));
            return response.Resource;
        }

        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<T>(id, new PartitionKey(id));
        }
    }

}
