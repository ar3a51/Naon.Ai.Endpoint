using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Naon.Ai.Endpoint.Models.DocumentModels;

namespace Naon.Ai.Endpoint.Repositories
{
    public class PostRepository : IPostRepository
    {
        private INaonContext _context;

        public PostRepository(INaonContext context)
        {
            _context = context;
        }
        public Task<PostDocument> GetPost(string postId)
        {

            FilterDefinition<PostDocument> filter = Builders<PostDocument>.Filter.Eq(p => p.PostId, new ObjectId(postId));
            return _context.Post.Find(filter).FirstOrDefaultAsync();
        }

        public async Task UpdateDescription(PostDocument postDocument)
        {
            await _context.Post.ReplaceOneAsync(
                 filter: (p) => p.PostId == postDocument.PostId,
                 replacement: postDocument);
        }
    }
}
