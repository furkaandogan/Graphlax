using System;

namespace Graphlax.Engine
{
    public interface IGraphEngine
    {
        GraphObject Read(Uri uri);
    }
}