using Microsoft.Extensions.Options;
using MongoDB.Driver;
using TV_web_API.Model;

namespace TV_web_API.Servise
{
    public class MongodbServicescs
    {
        private readonly IMongoCollection<tvsChannelcs> _tvChannelcs;

        public MongodbServicescs(IOptions<DatabaseConnector> set)
        {
            MongoClient client = new MongoClient(set.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(set.Value.DatabaseName);
            _tvChannelcs= database.GetCollection<tvsChannelcs>(set.Value.CollectionName);   

        }
        // get data from mongodbsources
         public async Task<List<tvsChannelcs>> GetAsync()=>
            await _tvChannelcs.Find(_=>true).ToListAsync();
    }
}
