using System;

namespace Graphlax
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class GraphTypeFormaterAttribute : Attribute
    {
     
        
        public GraphTypeFormaterAttribute()
        {
        }
    }
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class IntegerFormaterAttribute : Attribute
    {
     
        
        public IntegerFormaterAttribute()
        {
        }
    }
}