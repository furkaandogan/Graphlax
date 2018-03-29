using System;
using System.Threading.Tasks;

namespace Graphlax.Engine
{
    public interface IGraphEngine
    {
        Task<GraphObject> ReadAsync(Uri uri);
    }
}