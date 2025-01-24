using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class UserRequest(int? userId = null) : RequestBase(query:
    [
        new(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
    ]);
}
