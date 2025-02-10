namespace MeliLibToolsNext.APIs.Request.Items;

public class PriceToWinRequest(string meliId,string? version=null): RequestBase(query:
[
    new(name: "ITEM_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:meliId),
    new(name: "price_to_win", parameterType: QueryParameterType.NAME_ONLY,order:1),
    new(name: "version", parameterType: QueryParameterType.NAME_AND_VALUE,order:3,value:version),
]);