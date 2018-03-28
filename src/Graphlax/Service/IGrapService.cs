using System;

namespace Graphlax.Service
{
    public interface IGraphService
    {   
        GraphObject Get(Uri uri);
        
    }
}