using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Extensions;

namespace MeliLibToolsNext.APIs.Request.Products
{
    public class ProductRequest(string productId): RequestBase(query:
    [
        new(name: "PRODUCT_ID", parameterType: QueryParameterType.VALUE_ONLY,order:1,value:productId),
    ]);
}
