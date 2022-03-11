using Graphlax.Attributes;
using Graphlax.Attributes.Formaters;
using static Graphlax.Attributes.GraphElementAttribute;

namespace Graphlax.IMDB
{
    public class Film
    {
        
        
        [GraphElement("//*[@id='__next']/main/div/section[1]/section/div[3]/section/section/div[1]/div[1]/h1",ValueReadType.INNER_TEXT)]
        public string Name { get; set; }

        [GraphElement("/html/body/div[2]/main/div/section[1]/section/div[3]/section/section/div[1]/div[1]/div[2]/ul/li[3]",ValueReadType.INNER_TEXT)]
        public string Duraction { get; set; }
        
        [GraphElement("/html/body/div[2]/main/div/section[1]/section/div[3]/section/section/div[3]/div[2]/div[1]/div[2]/div/div[1]/a/div/div/div[2]/div[1]/span[1]",ValueReadType.INNER_TEXT)]
        public string AVGRating { get; set; }
        
        [GraphElement("/html/body/div[2]/main/div/section[1]/section/div[3]/section/section/div[3]/div[2]/div[1]/div[2]/div/div[1]/a/div/div/div[2]/div[1]/span[2]",ValueReadType.INNER_TEXT)]
        public string MaxRating { get; set; }
        
        [GraphElement("/html/body/div[2]/main/div/section[1]/section/div[3]/section/section/div[3]/div[2]/div[1]/div[2]/div/div[1]/a/div/div/div[2]/div[3]",ValueReadType.INNER_TEXT)]
        public string TotalRatingCount { get; set; }
        
        [GraphElement("/html/body/div[2]/main/div/section[1]/section/div[3]/section/section/div[1]/div[1]/div[2]/ul/li[1]/span",ValueReadType.INNER_TEXT)]
        public string VisionYear { get; set; }
    }
}