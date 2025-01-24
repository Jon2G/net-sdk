namespace MeliLibToolsNext.APIs.Request.User;

public class PaymentMethodRequest(int? userId = null) : RequestBase(query:
[
    new(name: "User_id", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:userId),
    new(name: "accepted_payment_methods", parameterType: QueryParameterType.NAME_ONLY,order:2),
]);