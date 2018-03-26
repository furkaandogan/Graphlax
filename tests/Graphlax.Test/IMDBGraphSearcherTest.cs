using System;
using Graphlax.IMDB;
using Xunit;

namespace Graphlax.Test
{
    public class IMDBGraphSearcherTest
    {
        IMDBGraphSearcher _graphSearcher;
        public IMDBGraphSearcherTest()
        {
            _graphSearcher=new IMDBGraphSearcher();
        }

        [Theory]
        [InlineData("http://www.imdb.com/title/tt1677720/?ref_=inth_ov_tt")]
        public void Search(string url)
        {
            Uri uri=new Uri(url);
            IMDBGraphObject graphObject=_graphSearcher.Search(uri);
            Console.Write(graphObject.Title);
            Assert.NotNull(graphObject);
            Assert.Equal(graphObject.Title,"Ready Player One (2018)");
            Assert.Equal(graphObject.Type,GraphType.WEB_SITE);
            Assert.Equal(graphObject.Description,"Directed by Steven Spielberg.  With Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe. When the creator of a virtual reality world called the OASIS dies, he releases a video in which he challenges all OASIS users to find his Easter Egg, which will give the finder his fortune.");
            Assert.Equal(graphObject.Url,uri.ToString());
            Assert.NotNull(graphObject.Image);
            Assert.Equal(graphObject.Image.Alt,string.Empty);
            Assert.Equal(graphObject.Image.Url,"https://ia.media-imdb.com/images/M/MV5BY2JiYTNmZTctYTQ1OC00YjU4LWEwMjYtZjkwY2Y5MDI0OTU3XkEyXkFqcGdeQXVyNTI4MzE4MDU@._V1_UY1200_CR90,0,630,1200_AL_.jpg");
            Assert.Equal(graphObject.Image.Width,0);
            Assert.Equal(graphObject.Image.Heigth,0);
            Assert.NotNull(graphObject.Site);
            Assert.Equal(graphObject.Site.Title,"Ready Player One (2018) - IMDb");
            Assert.Equal(graphObject.Site.Name,"www.imdb.com");
            Assert.Equal(graphObject.Site.IP,"127.0.0.1");

            Assert.NotNull(graphObject.Info);
            // Assert.Equal(graphObject.Info.Name,"Ready Player One");
            Assert.Equal(graphObject.Info.AVGRating,"8.0");
            Assert.Equal(graphObject.Info.Duraction,"2h 20min");
            Assert.Equal(graphObject.Info.MaxRating,"10");
            Assert.NotEqual(graphObject.Info.TotalRatingCount,null);
            Assert.Equal(graphObject.Info.VisionYear,"2018");
        }
    }
}
