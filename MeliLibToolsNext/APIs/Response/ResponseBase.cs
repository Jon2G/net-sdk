using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response
{
    public abstract class Response<T>(T data)
    {
        public T Data { get; } = data;
    }
}
