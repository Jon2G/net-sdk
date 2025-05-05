namespace MeliLibToolsNext.APIs.Request.User
{
    public class ApplicationsRequest(int? userId = null, string? applicationId = null) : RequestBase(query:
    [
        new(name: "$USER_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
        new(name: "applications", parameterType: QueryParameterType.NAME_ONLY,order:2),
        new(name: "$APPLICATION_ID", parameterType: QueryParameterType.VALUE_ONLY,order:3,value:applicationId),
    ]);
}
