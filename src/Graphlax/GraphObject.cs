using System;
using Graphlax.Attributes;
using Graphlax.Attributes.Formaters;
using static Graphlax.Attributes.GraphElementAttribute;

namespace Graphlax
{
    public class GraphObject
    {
        public string Url { get; set; }

        [GraphElement]
        public Site Site { get; set; }

        [GraphElement]
        public Image Image { get; set; }

        [GraphElement("/html/head/meta[@property='og:type']",ValueReadType.ATTRIBUTE,"content",GraphType.WEB_SITE)]
        [GraphTypeFormater]
        public GraphType Type{get;set;}

        [GraphElement("/html/head/meta[@property='og:title']",ValueReadType.ATTRIBUTE,"content")]
        public string Title{get;set;}

        [GraphElement("/html/head/meta[@property='og:description']",ValueReadType.ATTRIBUTE,"content")]
        public string Description{get;set;}

        public GraphObject()
        {

        }
        public GraphObject(Uri uri)
            :this()
        {
            Url=uri.ToString();
        }

    }
}