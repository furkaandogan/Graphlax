using System;
using System.Threading.Tasks;
using Graphlax.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graphlax.Api.Controllers
{
    public sealed class GraphEngineController
        : BaseController
    {
        public GraphEngineController()
        {

        }
        
        [HttpGet("engine/graph")]
        public async Task<GraphObject> EngineAsync(string url)
        {
            return await new Engine.GrapherEngine().ReadAsync(new Uri(url));
        }
        
    }
}