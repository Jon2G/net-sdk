using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class ApplicationsRequest(string? userId = null, string? applicationId = null) : RequestBase(query:
    [
        new QueryParameter(name: "$USER_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
        new QueryParameter(name: "applications", parameterType: QueryParameterType.NAME_ONLY,order:2),
        new QueryParameter(name: "$APPLICATION_ID", parameterType: QueryParameterType.VALUE_ONLY,order:3,value:applicationId),
    ]);
}
