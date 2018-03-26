using static Graphlax.GraphElementAttribute;

namespace Graphlax.Steam
{
    public class Game
    {
        [GraphElement(@"/html/body/div[1]/div[7]/div[3]/div[1]/div[2]/div[2]/div[2]/div/div[3]")]
        public string Name{get;set;}

        [GraphElement(@"//*[@id='game_area_purchase']/div/div/div[2]/div/div[1]")]
        public string Price{get;set;}

        [GraphElement(@"//*[@id='game_area_description']")]
        public string Description{get;set;}
    }
}