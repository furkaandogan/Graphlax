using System;
using HtmlAgilityPack;

namespace Graphlax
{
    public abstract class BaseGraphSearcher<TGraph>
        :IGraphSearcher<TGraph>
        where TGraph:GraphObject
    {
        public BaseGraphSearcher()
        {

        }

        public HtmlDocument GetHtmlDocument(Uri uri)
        {
            HtmlWeb web=new HtmlWeb();
            return web.Load(uri);
        }

        public abstract TGraph Search(Uri uri);
    }
}