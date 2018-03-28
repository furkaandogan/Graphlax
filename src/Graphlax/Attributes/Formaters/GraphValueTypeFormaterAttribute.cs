using System;

namespace Graphlax.Attributes.Formaters
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class GraphValueTypeFormaterAttribute : Attribute
    {
        readonly Func<object,object> _converter;
        public Func<object,object> Converter
        {
            get { return _converter; }
        }
        
        public GraphValueTypeFormaterAttribute(Func<object,object> converter)
        {
            this._converter = converter;
        }
    }
}