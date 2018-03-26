using System;

namespace Graphlax
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class GraphElementAttribute : Attribute
    {
        public enum ValueReadType:sbyte
        {
            INNER_TEXT=0,
            ATTRIBUTE=1
        }

        readonly string _selector;
        public string Selector
        {
            get { return _selector; }
        }
        readonly object _defaultValue;
        public object DefaultValue
        {
            get { return _defaultValue; }
        }
        readonly string _attributeName;
        public string AttributeName
        {
            get { return _attributeName; }
        }
        readonly ValueReadType _readType;
        public ValueReadType ReadType
        {
            get { return _readType; }
        }
        
        public GraphElementAttribute(string selector=null,ValueReadType valueReadType=ValueReadType.INNER_TEXT,string attributeName=null,object defaultValue=null)
        {
            this._selector = selector;
            this._readType=valueReadType;
            this._attributeName=attributeName;
            this._defaultValue=defaultValue;
        }
    }
}