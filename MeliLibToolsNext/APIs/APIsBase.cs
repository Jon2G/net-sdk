using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response;

namespace MeliLibToolsNext.APIs
{
    public abstract class APIsBase
    {
        protected abstract string Path { get; }
        protected APIsBase() { }


        protected Task<Response<T?>> Get<T>(RequestBase request)
        {
            //TODO
            throw new NotImplementedException();
        }


    }
}
