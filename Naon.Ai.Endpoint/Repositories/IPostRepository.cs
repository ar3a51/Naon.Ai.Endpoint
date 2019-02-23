using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Naon.Ai.Endpoint.Models.DocumentModels;

namespace Naon.Ai.Endpoint.Repositories
{
   public interface IPostRepository
    {
        Task<PostDocument> GetPost(string postId);
        Task UpdateDescription(PostDocument postDocument);
    }
}
