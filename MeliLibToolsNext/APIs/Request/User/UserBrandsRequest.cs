namespace MeliLibToolsNext.APIs.Request.User
{
    public class UserBrandsRequest(string userId) : RequestBase(query:
    [
        new QueryParameter(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
        new QueryParameter(name: "brands", parameterType: QueryParameterType.NAME_ONLY)
    ]);
}



