using System;
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
        public GraphObject Engine(string url)
        {
            return new Engine.GrapherEngine().Read(new Uri(url));
        }
        
    }
}