using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Newtonsoft;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.APIs.Response.Users;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs
{
    public abstract class APIsBase
    {

        internal static string AppId { private get; set; }
        internal static string ClientSecret { private get; set; }
        internal static AccessTokenData? AccessToken { get; set; }
        internal abstract string Path { get; }




        protected APIsBase() { }

        private void VerifyMethod(MethodInfo methodInfo, HttpMethods method)
        {
            var methodAttribute = methodInfo?.GetCustomAttributes(typeof(AvaibleHttpMethodsAttribute), true).FirstOrDefault() as AvaibleHttpMethodsAttribute;
            if (methodAttribute is null || !methodAttribute.Method.HasFlag(method))
                throw new InvalidOperationException("Method not allowed");
        }

        private MethodInfo GetMethod(string callerMember)
        {
            MethodInfo? methodInfo = this.GetType().GetMethod(callerMember);
            return methodInfo ?? throw new KeyNotFoundException();
        }

        private async Task Auth()
        {
            string url = $"/oauth/token?grant_type=client_credentials&client_id={AppId}&client_secret={ClientSecret}";
            var response = await API.Client.Request(url).PostAsync();
            //var str = await response.GetStringAsync();
            AccessToken = await response.GetJsonAsync<AccessTokenData>();
            if (string.IsNullOrEmpty(AccessToken.AccessToken) || AccessToken.UserId <= 0)
            {
                throw new Exception();
            }
        }

        protected async Task<Response.Response> Put<T>(RequestBase request, T? data, [CallerMemberName] string? callerMember = null)
        {
            await Task.Yield();

            //

            //
            if (AccessToken is null)
            {
                await Auth();
            }

            var methodInfo = GetMethod(callerMember!);


            var flurlRequest = request.BuildUrl(this, methodInfo);


            var response = await flurlRequest.PutJsonAsync(data);
            var str = await flurlRequest.GetStringAsync();
            return new Response.Response();


        }

        protected async Task<Response<T?>> Get<T>(RequestBase request, HttpMethods method = HttpMethods.GET, [CallerMemberName] string? callerMember = null)
        {
            await Task.Yield();

            //

            //
            if (AccessToken is null)
            {
                await Auth();
            }

            var methodInfo = GetMethod(callerMember!);

            VerifyMethod(methodInfo, method);


            var flurlRequest = request.BuildUrl(this, methodInfo);


            switch (method)
            {
                case HttpMethods.GET:
                    var str = await flurlRequest.GetStringAsync();
                    T? data = await flurlRequest.GetJsonAsync<T>();
                   
                    return new Response<T>(data);

                case HttpMethods.POST:

                case HttpMethods.PUT:


                case HttpMethods.DELETE:

                default:
                    throw new InvalidOperationException("Method not allowed");
            }

            var response = await flurlRequest.WithOAuthBearerToken(ClientSecret).GetJsonAsync<Response<T?>>();





        }


    }
}
