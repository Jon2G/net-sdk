using MeliLibToolsNext.APIs.Request;

namespace MeliLibToolsNext.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    internal class AvaibleHttpMethodsAttribute(HttpMethods method):Attribute
    {
        public HttpMethods Method { get; } = method;
    }
}
