namespace MeliLibToolsNext.APIs.Request.User
{
    public class UserRequest(long? userId = null) : RequestBase(query:
    [
        new(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
    ]);
}
