using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class UserBrandsRequest() : UserRequest(query:
    [
        new QueryParameter(name: "brands", parameterType: QueryParameterType.NAME_ONLY)
    ]);
}



