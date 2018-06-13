using System;
using System.Threading.Tasks;

namespace Graphlax.Service.Redis
{
    public class RedisDataProvider
        : IDataProvider
    {
        public RedisDataProvider()
        {

        }
        public async Task<GraphObject> GetGraphAsync(Uri uri)
        {
            GraphObject graphObject=null;
            return graphObject;
        }

        public async Task SetGraphAsync(GraphObject graphObject)
        {
            throw new NotImplementedException();
        }
    }
}