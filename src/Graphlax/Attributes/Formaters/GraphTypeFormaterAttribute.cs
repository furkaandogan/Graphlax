using System;

namespace Graphlax.Attributes.Formaters
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class GraphTypeFormaterAttribute : Attribute
    {
     
        
        public GraphTypeFormaterAttribute()
        {
        }
    }
}