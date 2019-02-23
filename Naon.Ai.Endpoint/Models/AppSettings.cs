using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naon.Ai.Endpoint.Models
{
    public class AppSettings
    {
        public string MongoDBConnectionString { set; get; }
        public string Database { set; get; }
        public string CognitiveApiKey { set; get; }
        public string ComputerVisionEndPoint { set; get; }
    }
}
