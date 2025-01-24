namespace MeliLibToolsNext.APIs.Request.User;

public class MissedFeedsRequest(int? userId = null, string? applicationId = null) : RequestBase(query:
[
    new(name: "app_id", parameterType: QueryParameterType.NAME_AND_VALUE,order:3,value:applicationId),
]);