using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.Request;

namespace MeliLibToolsNext.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class AvaibleHttpMethodsAttribute(HttpMethods method):Attribute
    {
        public HttpMethods Method { get; } = method;
    }
}
