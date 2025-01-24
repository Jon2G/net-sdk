namespace MeliLibToolsNext.Attributes;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class MethodNameAttribute(string? method) : Attribute
{
    public string? Method { get; } = method;
}