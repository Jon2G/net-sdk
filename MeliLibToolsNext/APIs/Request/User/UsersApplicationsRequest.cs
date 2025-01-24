namespace MeliLibToolsNext.APIs.Request.User;

public class UsersApplicationsRequest(int? userId = null, string? applicationId = null) : RequestBase(query:
[
    new(name: "users", parameterType: QueryParameterType.NAME_ONLY,order:1),
    new(name: "applications", parameterType: QueryParameterType.NAME_ONLY,order:2),
    new(name: "app_id", parameterType: QueryParameterType.VALUE_ONLY,order:3,value:applicationId),
]);