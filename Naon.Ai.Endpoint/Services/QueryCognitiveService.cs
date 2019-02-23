using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using Microsoft.Extensions.Options;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

using Naon.Ai.Endpoint.Models;
using Naon.Ai.Endpoint.Models.DocumentModels;

namespace Naon.Ai.Endpoint.Services
{
    public class QueryCognitiveService : IQueryCognitiveService
    {
        private readonly string _subscriptionKey;
        private readonly string _endPointUrl;

        public QueryCognitiveService(IOptions<AppSettings> options)
        {
            _subscriptionKey = options.Value.CognitiveApiKey;
            _endPointUrl = options.Value.ComputerVisionEndPoint;

        }
        public async Task<ImageAnalysis> QueryService(PostDocument post)
        {
            ComputerVisionClient computerVision = new ComputerVisionClient(
                new ApiKeyServiceClientCredentials(_subscriptionKey),
                new System.Net.Http.DelegatingHandler[] { });

            Stream stream = new MemoryStream(post.Image.ImageFile);
            ImageAnalysis analysis = await computerVision.AnalyzeImageInStreamAsync(stream, new List<VisualFeatureTypes>() {
                VisualFeatureTypes.Description,
                VisualFeatureTypes.Tags,
                VisualFeatureTypes.Objects
            });
            
            return analysis;
        }
    }
}
