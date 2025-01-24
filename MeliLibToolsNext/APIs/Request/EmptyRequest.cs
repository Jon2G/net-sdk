using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request
{
    public class EmptyRequest(Dictionary<string, string>? query=null) :RequestBase(query)
    {
    }
}
