using System;
using HtmlAgilityPack;

namespace Graphlax.IMDB
{
    public class IMDBGraphSearcher
        : BaseGraphSearcher<IMDBGraphObject>
    {
        public IMDBGraphSearcher()
        {
        }

        public override IMDBGraphObject Search(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}