using System;
using System.Threading.Tasks;
using Graphlax.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graphlax.Api.Controllers
{
    public sealed class GraphSearcherController
        : BaseController
    {
        public GraphSearcherController()
        {

        }

        [HttpGet("graph")]
        public GraphObject Index(string url)
        {
            DefaultGraphSearcher defaultGraphSearcher=new DefaultGraphSearcher();
            return defaultGraphSearcher.Search(new Uri(url));
        }
        [HttpGet("engine/graph")]
        public async Task<GraphObject> EngineAsync(string url)
        {
            return await new Engine.GrapherEngine().ReadAsync(new Uri(url));
        }
        
    }
}