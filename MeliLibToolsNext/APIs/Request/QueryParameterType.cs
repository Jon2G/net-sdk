namespace MeliLibToolsNext.APIs.Request;

public enum QueryParameterType
{
    /// <summary>
    /// [path].../endpoint/value1
    /// </summary>
    VALUE_ONLY,
    /// <summary>
    /// [path].../endpoint/param1
    /// </summary>
    NAME_ONLY,
    /// <summary>
    /// [path].../endpoint?param1=value1
    /// </summary>
    NAME_AND_VALUE
}