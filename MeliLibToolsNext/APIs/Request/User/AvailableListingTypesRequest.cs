using MeliLibToolsNext.APIs.Response.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class AvailableListingTypesRequest(int userId,string? listingType = null, string? categoryId = null) : RequestBase(query:
    [
        new(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
        new(name: "available_listing_types",order:1, parameterType: QueryParameterType.NAME_ONLY),
        new(name: "$LISTING_TYPE",order:2, parameterType: QueryParameterType.VALUE_ONLY,value:listingType),
        new(name: "categoryId",order:1, parameterType: QueryParameterType.NAME_AND_VALUE,value:categoryId)
    ]);
}
