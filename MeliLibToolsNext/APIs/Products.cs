using MeliLibToolsNext.APIs.Base;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response.Products;
using MeliLibToolsNext.APIs.Request.Products;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs
{
    public class Products : APIsBase
    {
        internal override string Path => "products";
        [AvaibleHttpMethods(HttpMethods.GET)]
        [Obsolete]
        public Task<Response<Product?>> Get(string productId)
        {
            return base.Get<Product>(new ProductRequest(productId));
        }
    }
}
