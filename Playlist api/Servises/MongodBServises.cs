using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Playlist_api.Model;

namespace Playlist_api.Servises
{
    public class MongodBServises
    {
        private readonly IMongoCollection<Playlist> _playCollections;
        public MongodBServises(IOptions<mongodbDatabase> mongoDbsettings)
        {
            MongoClient client = new MongoClient(mongoDbsettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDbsettings.Value.DatabaseName);
            _playCollections = database.GetCollection<Playlist>(mongoDbsettings.Value.CollectionName);

        }

        // create
        public async Task CreateAsync(Playlist playlist)
        {
            await _playCollections.InsertOneAsync(playlist);
            return;
        }
        // Get 
        public async Task<List<Playlist>> GetAsync() =>
            await _playCollections.Find(_ => true).ToListAsync();

        // Get by id 

        public async Task<List<Playlist>>GetbyidAsync(string id )=> 
            await _playCollections.Find(x=>x.Id == id).ToListAsync();   

        // Delete
        public async Task RemoveAsync(string id ) =>
            await _playCollections.DeleteOneAsync(x => x.Id == id);
        // Update by id 

        public async Task updateAsync(string id, Playlist upadteplaylist) =>
            await _playCollections.ReplaceOneAsync(x => x.Id == id, upadteplaylist);

    }
}
