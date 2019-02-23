using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Naon.Ai.Endpoint.Models;
using Naon.Ai.Endpoint.Models.DocumentModels;
using Naon.Ai.Endpoint.Repositories;

namespace Naon.Ai.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CognitiveController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly IPostRepository _postRepository;

        public CognitiveController(
            IOptionsMonitor<AppSettings> optionsMonitor,
            IPostRepository postRepository)
        {
            _appSettings = optionsMonitor.CurrentValue;
            _postRepository = postRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{postId}")]
        public async Task<ActionResult<PostDocument>> Get(string postId)
        {
            var resultPost = await _postRepository.GetPost(postId);
            return resultPost;
        }

        [HttpGet]
        [Route("settings")]
        public ActionResult<AppSettings> GetSettings()
        {
            return _appSettings;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
