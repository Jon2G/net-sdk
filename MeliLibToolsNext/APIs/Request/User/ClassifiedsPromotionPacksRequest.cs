using MeliLibToolsNext.APIs.Response.Users;
using MeliLibToolsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request.User
{
    public class ClassifiedsPromotionPacksRequest(string? listingType = null, string? categoryId = null) : UserRequest(query:
    [
        new QueryParameter(name: "classifieds_promotion_packs",order:1, parameterType: QueryParameterType.NAME_ONLY),
        new QueryParameter(name: "$LISTING_TYPE",order:2, parameterType: QueryParameterType.VALUE_ONLY,value:listingType),
        new QueryParameter(name: "categoryId",order:1, parameterType: QueryParameterType.NAME_AND_VALUE,value:categoryId)
    ]);
}
