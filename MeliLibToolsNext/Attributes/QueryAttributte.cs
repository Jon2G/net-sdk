using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    internal class QueryAttribute(string name, bool valueOnly = false, int order = 0) : Attribute
    {
        public string Name { get; } = name;
        public bool ValueOnly { get; } = valueOnly;
        public int Order { get; set; } = order;
    }
}
