using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Request
{
    public abstract class RequestBase(params QueryParameter[]? query)
    {
        public QueryParameter[] Query { get; } = query;


        public static RequestBase Empty => new EmptyRequest(null);
    }
}
