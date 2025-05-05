using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Flurl.Http;
using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.Attributes;

namespace MeliLibToolsNext.APIs.Base
{
    public abstract class APIsBase
    {

        internal static string AppId { private get; set; }
        internal static string ClientSecret { private get; set; }
        internal static string RedirectUrl { private get; set; }
        internal static string Code { private get; set; }
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
            MethodInfo? methodInfo = GetType().GetMethod(callerMember);
            return methodInfo ?? throw new KeyNotFoundException();
        }

        private async Task Auth()
        {
            if (string.IsNullOrEmpty(AppId) || string.IsNullOrEmpty(ClientSecret)|| string.IsNullOrEmpty(RedirectUrl)||string.IsNullOrEmpty(Code))
            {
                throw new InvalidOperationException("AppId and ClientSecret must be set by calling API.Configure('appId', 'clientSecret','redirectUrl','code')");
            }
            string url = $"/oauth/token?grant_type=client_credentials&client_id={AppId}&client_secret={ClientSecret}&code={Code}";
            var response = await API.Client.Request(url).PostAsync();
            var str = await response.GetStringAsync();
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

        protected async Task<IFlurlRequest> DoGet<T>(RequestBase request, HttpMethods method = HttpMethods.GET, [CallerMemberName] string? callerMember = null)
        {
            await Task.Yield();

            if (AccessToken is null)
            {
                await Auth();
            }

            var methodInfo = GetMethod(callerMember!);

            VerifyMethod(methodInfo, method);

            var flurlRequest = request.BuildUrl(this, methodInfo);

            return flurlRequest;
        }

        protected async Task<Response.Response<T>> Get<T>(RequestBase request, HttpMethods method = HttpMethods.GET, [CallerMemberName] string? callerMember = null)
        {
            IFlurlRequest flurlRequest = await DoGet<T>(request: request, method: method, callerMember: callerMember);
            var str = await flurlRequest.GetStringAsync();
            Debug.WriteLine(str);
            T? data = await flurlRequest.GetJsonAsync<T>();
            return new Response<T>(data);
        }


    }
}
