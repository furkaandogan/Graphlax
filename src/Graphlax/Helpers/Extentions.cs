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

        public static string GetAttributeValueWithNullCheck(this HtmlNode htmlNode,string attributeName,string defaultValue)
        {
            return htmlNode!=null?htmlNode.GetAttributeValue(attributeName,defaultValue):defaultValue;
        }

        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
    }
}