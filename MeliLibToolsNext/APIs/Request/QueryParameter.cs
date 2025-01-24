using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request
{
    public class QueryParameter(string name, string? value = null, int? order = 0, QueryParameterType? parameterType = null)
    {
        public string Name { get; } = name;
        public int Order { get; set; } = order ?? 0;
        public string? Value { get; set; } = value;
        public QueryParameterType ParameterType { get; } = parameterType ?? QueryParameterType.NAME_AND_VALUE;

    }
}
