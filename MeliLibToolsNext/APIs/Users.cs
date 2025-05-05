using MeliLibToolsNext.APIs.Request;
using MeliLibToolsNext.APIs.Response.Users;
using MeliLibToolsNext.Attributes;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.APIs.Response.Brands;
using MeliLibToolsNext.APIs.Request.User;
using MeliLibToolsNext.APIs.Response.Applications;
using MeliLibToolsNext.APIs.Base;

namespace MeliLibToolsNext.APIs
{
    public class Users : APIsBase
    {
        internal override string Path => "users";
        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("me")]
        public Task<Response<User?>> Me() => base.Get<User>(RequestBase.Empty);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<User?>> Get(UserRequest request) => base.Get<User>(request);

        [AvaibleHttpMethods(HttpMethods.PUT)]
        public Task<Response.Response> Update(UserRequest request, User? user) => base.Put<User>(request,user);


        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<AddressData[]?>> Addresses(UserAddressesRequest request) => base.Get<AddressData[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
 
        public Task<Response<PaymentMethod[]>> AcceptedPaymentMethods(PaymentMethodRequest request) => base.Get<PaymentMethod[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<BrandsData?>> Brands(BrandsRequest request) => Get<BrandsData>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> ClassifiedsPromotionPacks(ClassifiedsPromotionPacksRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> AvailableListingTypes(AvailableListingTypesRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> AvailableListingType(ApplicationsRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.DELETE)]
        public Task<Response<ApplicationData?>> UsersApplications(UsersApplicationsRequest request) => base.Get<ApplicationData>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("missed_feeds")]
        public Task<Response<MissedFeedsData?>> MissedFeeds(MissedFeedsRequest request) => base.Get<MissedFeedsData>(request);


    }
}
