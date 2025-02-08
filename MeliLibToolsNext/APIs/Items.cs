using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<Response<Item[]>> Get(params string[] meliId)
        {
            var response = await base.Get<BodyResponse<Item>[]>(new ItemRequest(meliId));
            Item?[] items=response.Data?.Select(x => x.Data)?.ToArray() ?? [];
            return new Response<Item[]>(items!);
        }


        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<SalePrice?>> SalePrice(SalePriceRequest request) => base.Get<SalePrice>(request);
    }
}
