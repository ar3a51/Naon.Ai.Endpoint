using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Naon.Ai.Endpoint.Models;
using Naon.Ai.Endpoint.Models.DocumentModels;

using Microsoft.Extensions.Options;

namespace Naon.Ai.Endpoint.Repositories
{
    public class NaonContext:INaonContext
    {
        private readonly IMongoDatabase _db;
        public NaonContext(IOptions<AppSettings> options)
        {
            MongoClient client = new MongoClient(options.Value.MongoDBConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<PostDocument> Post => _db.GetCollection<PostDocument>("posts");
    }
}
