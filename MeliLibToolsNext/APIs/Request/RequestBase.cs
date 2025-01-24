using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Request
{
    public abstract class RequestBase(params QueryParameter[]? query)
    {

        public QueryParameter[] Query { get; } = query;


        public static RequestBase Empty => new EmptyRequest();



        private string? MethodName(MethodInfo methodInfo)
        {
            return methodInfo.GetCustomAttribute<MethodNameAttribute>()?.Method;
        }

        public IFlurlRequest BuildUrl(APIsBase forApi, MethodInfo methodInfo)
        {
            var request = API.Client.Request().WithOAuthBearerToken(APIsBase.AccessToken.AccessToken);

            request.AppendPathSegment(forApi.Path);

            string? methodName = MethodName(methodInfo);
            if (methodName is not null)
            {
                request.AppendPathSegment(methodName);
            }

            foreach (var queryParameter in this.Query.OrderBy(x => x.Order))
            {
                switch (queryParameter.ParameterType)
                {
                    case QueryParameterType.NAME_AND_VALUE:
                        request.AppendQueryParam("access_token", APIsBase.AccessToken.AccessToken);
                        break;
                    case QueryParameterType.NAME_ONLY:
                        request.AppendPathSegment(queryParameter.Name);
                        break;
                    case QueryParameterType.VALUE_ONLY:
                        request.AppendPathSegment(queryParameter.Value);
                        break;
                }
            }





            return request;
        }
    }
}
