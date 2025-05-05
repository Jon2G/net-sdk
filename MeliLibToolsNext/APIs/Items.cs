using MeliLibToolsNext.APIs.Base;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Request.Items;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.APIs.Response.Items;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs
{
    public class Items : APIsBase
    {
        internal override string Path => "items";

        [AvaibleHttpMethods(HttpMethods.GET)]
        [Obsolete("Since April 2025 you cannot search on items of other sellers")]
        public async Task<Response<Item[]>> Get(params string[] meliId)
        {
            var response = await base.Get<BodyResponse<Item>[]>(new ItemRequest(meliId));
            Item?[] items=response.Data?.Select(x => x.Data)?.ToArray() ?? [];
            return new Response<Item[]>(items!);
        }


        [AvaibleHttpMethods(HttpMethods.GET)]
        [Obsolete("Since April 2025 you cannot search on items of other sellers")]
        public Task<Response<SalePrice?>> SalePrice(SalePriceRequest request) => base.Get<SalePrice>(request);


        

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PriceToWin?>> PriceToWin(PriceToWinRequest request) => base.Get<PriceToWin>(request);
    }
}
