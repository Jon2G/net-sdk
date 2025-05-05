namespace MeliLibToolsNext.APIs.Request.User
{
    public class ClassifiedsPromotionPacksRequest(int userId,string? listingType = null, string? categoryId = null) : RequestBase(query:
    [
        new QueryParameter(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
        new QueryParameter(name: "classifieds_promotion_packs",order:1, parameterType: QueryParameterType.NAME_ONLY),
        new QueryParameter(name: "$LISTING_TYPE",order:2, parameterType: QueryParameterType.VALUE_ONLY,value:listingType),
        new QueryParameter(name: "categoryId",order:1, parameterType: QueryParameterType.NAME_AND_VALUE,value:categoryId)
    ]);
}
