using System;
using HtmlAgilityPack;

namespace Graphlax.Helpers
{
    public static class Extentions
    {
        public static GraphType ToGraphType(this string type)
        {
            switch(type.ToLower())
            {
                case "website":
                    return GraphType.WEB_SITE;
                default:
                    return GraphType.WEB_SITE;
            }
        }   
        public static object ToGraphType(this object type)
        {
            switch(type.ToString().ToLower())
            {
                case "website":
                    return GraphType.WEB_SITE;
                default:
                    return GraphType.WEB_SITE;
            }
        }


        public static string GetAttributeValueWithNullCheck(this HtmlNode htmlNode,string attributeName,string defaultValue)
        {
            return htmlNode!=null?htmlNode.GetAttributeValue(attributeName,defaultValue):defaultValue;
        }
        
        public static object GetAttributeValueWithNullCheck(this HtmlNode htmlNode,string attributeName,object defaultValue)
        {
            if(htmlNode==null)
                return defaultValue;
            if(defaultValue==null)
                defaultValue="";
            return htmlNode.GetAttributeValue(attributeName,defaultValue.ToString()).ToString().Trim();
        }

        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static Type ToGraphType(this Uri uri)
        {
            if(uri.ToString().Contains("imdb.com"))
                return typeof(IMDB.IMDBGraphObject);
            else if(uri.ToString().Contains("store.steampowered.com"))
                return typeof(Steam.SteamGraphObject);
            return typeof(GraphObject);
        }
    }
}