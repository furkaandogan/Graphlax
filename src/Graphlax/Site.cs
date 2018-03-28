using Graphlax.Attributes;
using Graphlax.Attributes.Formaters;
using static Graphlax.Attributes.GraphElementAttribute;

namespace Graphlax
{
    public class Site
    {
        public string Name{get;set;}
    
        [GraphElement(@"/html/head/title",ValueReadType.INNER_TEXT)]
        public string Title {get;set;}
        public string IP {get;set;}        
    }
}