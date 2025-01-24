namespace MeliLibToolsNext.APIs.Request.User;

public class BrandsRequest(int? userId = null) : RequestBase(query:
[
    new(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
    new(name: "brands", parameterType: QueryParameterType.NAME_ONLY,order:2),
]);