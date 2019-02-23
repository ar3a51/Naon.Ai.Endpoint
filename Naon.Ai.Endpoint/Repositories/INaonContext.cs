using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Naon.Ai.Endpoint.Models.DocumentModels;
using MongoDB.Driver;

namespace Naon.Ai.Endpoint.Repositories
{
    public interface INaonContext
    {
        IMongoCollection<PostDocument> Post { get; }
    }
}
