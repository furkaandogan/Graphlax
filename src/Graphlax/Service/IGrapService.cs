using System;
using System.Threading.Tasks;

namespace Graphlax.Service
{
    public interface IGraphService
    {   
        Task<GraphObject> GetAsync(Uri uri);
        
    }
}