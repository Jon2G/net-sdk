using Flurl.Http;
using MeliLibToolsNext.APIs;
using MeliLibToolsNext.APIs.Base;
using Newtonsoft.Json;

namespace MeliLibToolsNext
{
    public static class API
    {
        internal const string BaseUrl = "https://api.mercadolibre.com";
        private static readonly Lazy<APIs.Items> _Items = new(() => new());
        public static Items Items => _Items.Value;

        private static readonly Lazy<APIs.Users> _Users = new(() => new());
        public static Users Users => _Users.Value;

        private static readonly Lazy<APIs.Products> _Products = new(() => new());
        public static Products Products => _Products.Value;
        

        internal static Flurl.Http.FlurlClient Client { get; private set; }
        public static void Configure(string appId, string clientSecret,string redirectUrl,string code)
        {
            APIsBase.AppId = appId;
            APIsBase.ClientSecret = clientSecret;
            APIsBase.RedirectUrl = redirectUrl;
            APIsBase.Code = code;

            // this is needed when serializing classes to prevent circular loop error
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            // create a Newtonsoft-based serializer for Flurl to use
            var serializer = new Flurl.Http.Newtonsoft.NewtonsoftJsonSerializer(settings);

            Client = new Flurl.Http.FlurlClient(BaseUrl);
            Client = Client.WithSettings(settings => settings.JsonSerializer = serializer);
        }
    }
}
