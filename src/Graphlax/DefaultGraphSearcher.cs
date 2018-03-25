using System;
using HtmlAgilityPack;
using Graphlax.Helpers;

namespace Graphlax
{
    public class DefaultGraphSearcher
        :BaseGraphSearcher<GraphObject>
    {
        public DefaultGraphSearcher()
        {

        }


        public override GraphObject Search(Uri uri)
        {
            HtmlDocument htmlDocument=base.GetHtmlDocument(uri);
            if(htmlDocument==null)
            {
                throw new NullReferenceException(nameof(htmlDocument));
            }
            
            HtmlNode titleNode = htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:title']");
            HtmlNode siteTitleNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/title");
            HtmlNode descriptionNode = htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[property='og:description']");
            HtmlNode typeNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[property='og:type']");
            HtmlNode imageSrcNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:image']");
            HtmlNode imageTypeNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:image:type']");
            HtmlNode imageHeightNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:image:height']");
            HtmlNode imageWidthNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:image:width']");
            HtmlNode imageAltNode=htmlDocument
                .DocumentNode
                .SelectSingleNode(@"/html/head/meta[@property='og:image:alt']");
            
            return new GraphObject(){
                Url=uri.ToString(),
                Title=titleNode.GetAttributeValueWithNullCheck("content",string.Empty),
                Type=typeNode.GetAttributeValueWithNullCheck("content",string.Empty).ToGraphType(),
                Description=descriptionNode.GetAttributeValueWithNullCheck("content",string.Empty),
                Image=new Graphlax.Image(){
                    Heigth=imageHeightNode.GetAttributeValueWithNullCheck("content","0").ToInt(),
                    Width=imageWidthNode.GetAttributeValueWithNullCheck("content","0").ToInt(),
                    Url=imageSrcNode.GetAttributeValueWithNullCheck("content",string.Empty).ToString(),
                    Alt=imageAltNode.GetAttributeValueWithNullCheck("content",string.Empty)
                },
                Site=new Graphlax.Site(){
                    Title=siteTitleNode.InnerText.ToString(),
                    Name=uri.Host.ToString(),
                    IP="127.0.0.1"
                }
            };
        }
    }
}