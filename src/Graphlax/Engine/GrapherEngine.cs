using System;
using System.Linq;
using System.Reflection;
using Graphlax.Helpers;
using HtmlAgilityPack;
using Graphlax.Attributes;
using Graphlax.Attributes.Formaters;
using static Graphlax.Attributes.GraphElementAttribute;
using Graphlax.Utilities.Net;
using System.Threading.Tasks;

namespace Graphlax.Engine
{
    public sealed class GrapherEngine
        :IGraphEngine
    {
        public GrapherEngine()
        {

        }

        public async Task<GraphObject> ReadAsync(Uri uri)
        {
            Type graphType=uri.ToGraphType();
            object graphObject=Activator.CreateInstance(graphType);
            PropertyInfo[] properties = graphType.GetProperties()
                .Where(x=>Attribute.IsDefined(x,typeof(GraphElementAttribute))).ToArray();
            HtmlDocument htmlDocument=HtmlClient.LoadDocument(uri);
            foreach(PropertyInfo prop in properties){
                if(prop.PropertyType.IsClass && (prop.PropertyType.Module.Name.Contains("Graphlax"))){
                     prop.SetValue(graphObject,GetSubPropValue(prop.PropertyType,htmlDocument));
                }else{
                     prop.SetValue(graphObject,GetPropValue(prop,htmlDocument));
                }
            }
            ((GraphObject)graphObject).Url=uri.ToString();
            ((GraphObject)graphObject).Site.Name=uri.Host;
            ((GraphObject)graphObject).Site.IP="127.0.0.1";
            return ((GraphObject)graphObject);
        }

        private object GetSubPropValue(Type propType,HtmlDocument htmlDocument)
        {
            object value=Activator.CreateInstance(propType);
            PropertyInfo[] properties = propType.GetProperties()
                .Where(x=>Attribute.IsDefined(x,typeof(GraphElementAttribute))).ToArray();
            foreach(PropertyInfo prop in properties){
                if(prop.PropertyType.IsClass && (prop.PropertyType.Module.Name.Contains("Graphlax"))){
                     prop.SetValue(value,GetSubPropValue(prop.PropertyType,htmlDocument));
                }else{
                     prop.SetValue(value,GetPropValue(prop,htmlDocument));
                }
            }
            return value;
        }

        private object GetPropValue(PropertyInfo prop,HtmlDocument htmlDocument){
            object value=null;
            GraphElementAttribute graphElementAttribute=(GraphElementAttribute)prop.GetCustomAttribute(typeof(GraphElementAttribute));
            if(graphElementAttribute.Selector!=null){
                HtmlNode htmlNode=htmlDocument
                    .DocumentNode
                    .SelectSingleNode(graphElementAttribute.Selector);
                switch (graphElementAttribute.ReadType)
                {
                    case ValueReadType.ATTRIBUTE:
                        if(Attribute.IsDefined(prop,typeof(GraphTypeFormaterAttribute))){
                           value=htmlNode.GetAttributeValueWithNullCheck(graphElementAttribute.AttributeName,graphElementAttribute.DefaultValue.ToString()).ToString().ToGraphType();
                        }else if(Attribute.IsDefined(prop,typeof(IntegerFormaterAttribute))){
                            value=htmlNode.GetAttributeValueWithNullCheck(graphElementAttribute.AttributeName,graphElementAttribute.DefaultValue.ToString()).ToString().ToInt();
                        }else{
                          value=htmlNode.GetAttributeValueWithNullCheck(graphElementAttribute.AttributeName,graphElementAttribute.DefaultValue);
                        }
                    break;
                    case ValueReadType.INNER_TEXT:
                        value=htmlNode.InnerText.Trim();
                    break;
                    default:
                        value=htmlNode.InnerText.Trim();
                    break;
                }
            }
            return value;
        }
    }
}