namespace PsmTestsConsole.Helpers
{
    using Entities;
    using MongoDB.Bson;
    using MongoDB.Driver;

    public class MongoHelper
    {
        private const string connectionString = "mongodb://localhost";
        private IMongoCollection<BsonDocument> collection;

        public MongoHelper()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CAR_WASHER_Colletions");
            this.collection = database.GetCollection<BsonDocument>("Docs_Washer");
        }

        public void InsertOrUpdateWasher(Washer washer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", washer.Id);

            this.collection.ReplaceOne(filter, washer.ToBsonDocument(), new UpdateOptions { IsUpsert = true });
        }
    }
}