using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using Naon.Ai.Endpoint.Models;

namespace Naon.Ai.Endpoint.Models.DocumentModels
{
    public class PostDocument:BsonBaseModel
    {
        [BsonId]
        public ObjectId PostId { set; get; }

        [BsonElement("username")]
        public string Username { set; get; }

        [BsonElement("message")]
        public string Message { set; get; }

        [BsonElement("postType")]
        public string PostType { set; get; }

        [BsonElement("dateTime")]
        public DateTime DateTime { set; get; }

        [BsonElement("image")]
        public Image Image { set; get; }        
    }

    public class Image
    {
        [BsonElement("imageFile")]
        public Byte[] ImageFile { set; get; }
        [BsonElement("description")]
        public string Description { set; get; }
        [BsonElement("extension")]
        public string Extension { set; get; }
    }
}
