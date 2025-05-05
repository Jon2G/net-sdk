namespace MeliLibToolsNext.APIs.Request
{
    public class QueryParameter(string name, object? value = null, int? order = 0, QueryParameterType? parameterType = null)
    {
        public string Name { get; } = name;
        public int Order { get; set; } = order ?? 0;
        public object? Value { get; set; } = value;
        public QueryParameterType ParameterType { get; } = parameterType ?? QueryParameterType.NAME_AND_VALUE;



    }
    internal static class QueryParameterConverter
    {

        public static QueryParameter MultiValuesQueryParameter(this QueryParameter queryParameter)
        {
            if(queryParameter.Value is not string[])
            {
                throw new ArgumentException("Value must be a string array");
            }
            queryParameter.Value = string.Join(",",(string[])queryParameter.Value);
            return queryParameter;
        }

    }
}
