using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.Attributes;
using MeliLibToolsNext.APIs.Request.User;
using MeliLibToolsNext.APIs.Response.Applications;
using MeliLibToolsNext.APIs.Base;

namespace MeliLibToolsNext.APIs
{
    public class Applications : APIsBase
    {
        internal override string Path => "applications";

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<ApplicationData?>> Get(ApplicationRequest request) => base.Get<ApplicationData>(request);
    }
}
