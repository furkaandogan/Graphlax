using System;
using System.Threading.Tasks;

namespace Graphlax.Service
{
    public interface IDataProvider
    {
        Task<GraphObject> GetGraphAsync(Uri uri);
        Task SetGraphAsync(GraphObject graphObject);
        
    }
}