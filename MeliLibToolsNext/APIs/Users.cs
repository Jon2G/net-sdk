using MeliLibToolsNext.APIs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.Response.Users;
using MeliLibToolsNext.Attributes;
using MeliLibToolsNext.APIs.Response;
using MeliLibToolsNext.APIs.Response.Brands;
using MeliLibToolsNext.APIs.Request.User;

namespace MeliLibToolsNext.APIs
{
    public class Users : APIsBase
    {
        protected override string Path => "users";

        [AvaibleHttpMethods(HttpMethods.GET|HttpMethods.PUT)]
        public Task<Response<User?>> Get(UserRequest request) => base.Get<User>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<User?>> Me() => base.Get<User>(RequestBase.Empty);

        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("addresses")]
        public Task<Response<AddressData?>> Addresses(UserRequest request) => base.Get<AddressData>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("accepted_payment_methods")]
        public Task<Response<PaymentMethod[]>> AcceptedPaymentMethods(UserRequest request) => base.Get<PaymentMethod[]>(request);
        
        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("brands")]
        public Task<Response<BrandsData?>> Brands(UserRequest request) => Get<BrandsData>(request);

        //[AvaibleHttpMethods(HttpMethods.GET | HttpMethods.POST)]
        //[MethodName("classifieds_promotion_packs")]
        //public Task<Response<PromotionPack[]?>> ClassifiedsPromotionPacks(UserRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> ClassifiedsPromotionPacks(ClassifiedsPromotionPacksRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> AvailableListingTypes(AvailableListingTypesRequest request) => base.Get<PromotionPack[]>(request);

        //TODO:

        [AvaibleHttpMethods(HttpMethods.GET)]
        public Task<Response<PromotionPack[]?>> AvailableListingTypes(ApplicationsRequest request) => base.Get<PromotionPack[]>(request);

        [AvaibleHttpMethods(HttpMethods.GET)]
        [MethodName("missed_feeds")]
        public Task<Response<PromotionPack[]?>> MissedFeeds(MissedFeedsRequest request) => base.Get<PromotionPack[]>(request);

        /*
       /users/$USER_ID/applications/$APPLICATION_ID
        /missed_feeds?app_id=$APP_ID
         */


    }
}
