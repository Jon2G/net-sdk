namespace MeliLibToolsNext.APIs.Request.User;

public class UserAcceptedPaymentMethodsRequest(string userId) : RequestBase(query:
[
    new QueryParameter(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
    new QueryParameter(name: "accepted_payment_methods", parameterType: QueryParameterType.NAME_ONLY)
]);