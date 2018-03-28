using System;

namespace Graphlax.Service
{
    public class GraphService
        :IGraphService
    {
        private readonly Engine.IGraphEngine _graphEngine;
        public GraphService(Engine.IGraphEngine graphEngine)
        {
            _graphEngine=graphEngine;
        }

        public GraphObject Get(Uri uri)
        {
            GraphObject graphObject=null;
            
            if(graphObject==null){
                graphObject=_graphEngine.Read(uri);
            }
            return graphObject;
        }
    }
}