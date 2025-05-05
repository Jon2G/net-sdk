using MeliLibToolsNext.Extensions;

namespace MeliLibToolsNext.APIs.Request.Items
{
    public class SalePriceRequest(string meliId,ESalesChannel salesChannel=ESalesChannel.MARKETPLACE): RequestBase(query:
    [
        new(name: "ITEM_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:meliId),
        new(name: "sale_price", parameterType: QueryParameterType.NAME_ONLY,order:2),
        new(name: "context", parameterType: QueryParameterType.NAME_AND_VALUE,order:3,value:salesChannel.GetStringValue()),
    ]);
}
