using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response
{
    public class Response
    {
        public Response()
        {
            
        }
    }
    public class Response<T>(T? data) : Response
    {
        public T? Data { get; } = data;
    }
}
