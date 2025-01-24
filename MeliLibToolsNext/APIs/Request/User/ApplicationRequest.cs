namespace MeliLibToolsNext.APIs.Request.User;

public class ApplicationRequest(string? userId = null, string? applicationId = null) : RequestBase(query:
[
    new(name: "$APPLICATION_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:applicationId),
]);