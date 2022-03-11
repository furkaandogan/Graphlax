using Graphlax.Attributes;
using static Graphlax.Attributes.GraphElementAttribute;

namespace Graphlax.Steam
{
    public class Game
    {
        [GraphElement(@"//div[@id='appHubAppName']")]
        public string Name{get;set;}

        [GraphElement(@"//div[@id='game_area_purchase']")]
        public string Price{get;set;}

        [GraphElement(@"//div[@id='game_area_description']")]
        public string Description{get;set;}
    }
}