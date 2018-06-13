using System;
using System.Threading.Tasks;

namespace Graphlax.Service
{
    public class GraphService
        :IGraphService
    {
        private readonly Engine.IGraphEngine _graphEngine;
        private readonly IDataProvider _tempDataProvider;
        public GraphService(Engine.IGraphEngine graphEngine,IDataProvider tempDataProvider)
        {
            _graphEngine=graphEngine;
            _tempDataProvider=tempDataProvider;
        }

        public async Task<GraphObject> GetAsync(Uri uri)
        {
            GraphObject graphObject=await _tempDataProvider.GetGraphAsync(uri);
            if(graphObject==null){
                graphObject=await _graphEngine.ReadAsync(uri);

            }
            return graphObject;
        }
    }
}