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
            IMDBGraphObject imdbGraphObject=base.Search(uri);
            HtmlNode nameNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='title-overview-widget']/div[2]/div[2]/div/div[2]/div[2]/h1");

            HtmlNode visionYearNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='titleYear']/a");

            HtmlNode duractionNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='title-overview-widget']/div[2]/div[2]/div/div[2]/div[2]/div/time");

            HtmlNode avgRatingValueNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/div[1]/strong/span");

            HtmlNode maxRatingValueNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/div[1]/span[2]");

            HtmlNode totalRatingCountNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"//*[@id='title-overview-widget']/div[2]/div[2]/div/div[1]/div[1]/a/span");
                
            imdbGraphObject.Info=new Film(){
                Name=nameNode.InnerText.Trim(),
                VisionYear=visionYearNode.InnerText.Trim(),
                Duraction=duractionNode.InnerText.Trim(),
                AVGRating=avgRatingValueNode.InnerText.Trim(),
                MaxRating=maxRatingValueNode.InnerText.Trim(),
                TotalRatingCount=totalRatingCountNode.InnerText.Trim()
            };
            return imdbGraphObject;
        }
    }
}