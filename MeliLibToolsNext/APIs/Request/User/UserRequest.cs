using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class UserRequest(string? userId = null, params QueryParameter[]? query) : RequestBase(query)
    {
        [Query(name: "User_id", valueOnly: true, order: 1)]
        public string UserId { get; set; } = userId;
    }
}
