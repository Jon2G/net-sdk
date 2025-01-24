using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Request
{
    public class ApplicationRequest(string? applicationId, params QueryParameter[]? query) : RequestBase(query)
    {
        [Query(name: "APPLICATION_ID", valueOnly: true, order: 1)]
        public string? ApplicationId { get; set; } = applicationId;
    }
}
