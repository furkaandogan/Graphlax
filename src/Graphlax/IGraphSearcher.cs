using System;

namespace Graphlax
{
    public interface IGraphSearcher<TGraph>
        where TGraph:GraphObject
    {
        TGraph Search(Uri uri);
    }
}