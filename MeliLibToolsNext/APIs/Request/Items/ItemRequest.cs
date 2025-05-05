namespace MeliLibToolsNext.APIs.Request.Items
{
    public class ItemRequest(params string[] meliId) : RequestBase(query:
    [
      QueryParameterConverter.MultiValuesQueryParameter(
        new(name: "ids", parameterType: QueryParameterType.NAME_AND_VALUE,order:0,value: meliId))
        ]);
}
