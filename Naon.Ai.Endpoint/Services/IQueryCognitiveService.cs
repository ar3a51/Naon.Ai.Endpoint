using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Naon.Ai.Endpoint.Models.DocumentModels;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace Naon.Ai.Endpoint.Services
{
    public interface IQueryCognitiveService
    {
        Task<ImageAnalysis> QueryService(PostDocument postDocument);
    }
}
