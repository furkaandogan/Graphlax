using Graphlax.Attributes;
using static Graphlax.Attributes.GraphElementAttribute;

namespace Graphlax
{
    public class Image
    {
        [GraphElement("/html/head/meta[@property='og:image:alt']",ValueReadType.ATTRIBUTE,"content")]
        public string Alt{get;set;}

        [GraphElement("/html/head/meta[@property='og:image:type']",ValueReadType.ATTRIBUTE,"content")]
        public string Type { get; set; }

        [GraphElement("/html/head/meta[@property='og:image']",ValueReadType.ATTRIBUTE,"content")]
        public string Url{get;set;}

        [GraphElement("/html/head/meta[@property='og:image:width']",ValueReadType.ATTRIBUTE,"content",0)]
        [IntegerFormater]
        public int Width{get;set;}

        [GraphElement("/html/head/meta[@property='og:image:height']",ValueReadType.ATTRIBUTE,"content",0)]
        [IntegerFormater]
        public int Heigth{get;set;}

    }
}