namespace MeliLibToolsNext.APIs.Request.User;

public class UserAcceptedPaymentMethodsRequest() : UserRequest(query:
[
    new QueryParameter(name: "accepted_payment_methods", parameterType: QueryParameterType.NAME_ONLY)
]);