using static Graphlax.GraphElementAttribute;

namespace Graphlax.IMDB
{
    public class Film
    {
        
        
        [GraphElement("//*[@id='title-overview-widget']/div[2]/div[2]/div/div[2]/div[2]/h1",ValueReadType.INNER_TEXT)]
        public string Name { get; set; }

        [GraphElement("//*[@id='title-overview-widget']/div[2]/div[2]/div/div[2]/div[2]/div/time",ValueReadType.INNER_TEXT)]
        public string Duraction { get; set; }
        
        [GraphElement("//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/div[1]/strong/span",ValueReadType.INNER_TEXT)]
        public string AVGRating { get; set; }
        
        [GraphElement("//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/div[1]/span[2]",ValueReadType.INNER_TEXT)]
        public string MaxRating { get; set; }
        
        [GraphElement("//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/a/span",ValueReadType.INNER_TEXT)]
        public string TotalRatingCount { get; set; }
        
        [GraphElement("//*[@id='titleYear']/a",ValueReadType.INNER_TEXT)]
        public string VisionYear { get; set; }
    }
}