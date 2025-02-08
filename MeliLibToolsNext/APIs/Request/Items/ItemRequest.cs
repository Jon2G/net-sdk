using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Extensions;

namespace MeliLibToolsNext.APIs.Request.Items
{
    public class ItemRequest(params string[] meliId) : RequestBase(query:
    [
      QueryParameterConverter.MultiValuesQueryParameter(
        new(name: "ids", parameterType: QueryParameterType.NAME_AND_VALUE,order:0,value: meliId))
        ]);
}
