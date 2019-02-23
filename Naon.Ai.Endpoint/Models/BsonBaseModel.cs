using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Naon.Ai.Endpoint.Models
{
    public class BsonBaseModel
    {
        [BsonElement("__v")]
        public int Version { set; get; }
    }
}
