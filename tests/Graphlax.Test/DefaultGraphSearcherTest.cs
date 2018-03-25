using System;
using Xunit;

namespace Graphlax.Test
{
    public class DefaultGraphSearcherTest
    {
        DefaultGraphSearcher _defaultGraphSearcher;
        public DefaultGraphSearcherTest()
        {
            _defaultGraphSearcher=new DefaultGraphSearcher();
        }

        [Theory]
        [InlineData("http://ogp.me/")]
        public void Search(string url)
        {
            Uri uri=new Uri(url);
            GraphObject graphObject=_defaultGraphSearcher.Search(uri);
            Console.Write(graphObject.Title);
            Assert.NotNull(graphObject);
            Assert.Equal(graphObject.Title,"Open Graph protocol");
            Assert.Equal(graphObject.Type,GraphType.WEB_SITE);
            Assert.Equal(graphObject.Description,"The Open Graph protocol enables any web page to become a rich object in a social graph.");
            Assert.Equal(graphObject.Url,uri.ToString());
            Assert.NotNull(graphObject.Image);
            Assert.Equal(graphObject.Image.Alt,"The Open Graph logo");
            Assert.Equal(graphObject.Image.Url,"http://ogp.me/logo.png");
            Assert.Equal(graphObject.Image.Width,300);
            Assert.Equal(graphObject.Image.Heigth,300);
            Assert.NotNull(graphObject.Site);
            Assert.Equal(graphObject.Site.Title,"The Open Graph protocol");
            Assert.Equal(graphObject.Site.Name,"ogp.me");
            Assert.Equal(graphObject.Site.IP,"127.0.0.1");
        }
    }
}
