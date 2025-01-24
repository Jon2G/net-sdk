using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response;

namespace MeliLibToolsNext.APIs
{
    public class Items : APIsBase
    {
        internal override string Path => "items";

        public Task<Response<Item?>> Get(string meliId)
        {
            //TODO
            return base.Get<Item>(RequestBase.Empty);
        }
    }
}
