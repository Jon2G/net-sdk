using FluentAssertions;
using MeliLibToolsNext.APIs.Response.Users;
using Xunit.Sdk;

namespace MeliLibToolsNext.Test
{
    public class UsersAPITest
    {
        const int UserId = 170099147;
        const string AppId = "9005856443171440";
        const string ClientSecret = "oghjNATLtotJfo3US6KzEfXkuzS5SI8r";
        const string RedirectUrl="https://reparaciondeboiler.com/";

        public UsersAPITest()
        {
            MeliLibToolsNext.API.Configure(AppId, ClientSecret,RedirectUrl);
        }

        [Fact]
        public async Task Me()
        {
            var response = await API.Users.Me();
            response.Data.Should().NotBeNull();
        }

        [Fact]
        public async Task Get()
        {
            var user = await API.Users.Get(new(userId: UserId));
            user.Data.Should().NotBeNull();
            user.Data.Id.Should().Be(UserId);
        }

        [Fact]
        public async Task Update()
        {
            var user = await API.Users.Update(new(userId: UserId), new User()
            {
                Nickname="Jon2G"
            });
        }

        [Fact]
        public async Task Addresses()
        {
            var user = await API.Users.Addresses(new(userId: UserId));
        }

        [Fact]
        public async Task AcceptedPaymentMethods()
        {
            var user = await API.Users.AcceptedPaymentMethods(new(userId: UserId));
        }

        [Fact]
        public async Task Brands()
        {
            var brands = await API.Users.Brands(new(userId: UserId));
        }

        [Fact]
        public async Task ClassifiedsPromotionPacks()
        {
            var brands = await API.Users.ClassifiedsPromotionPacks(new(userId: UserId));
        }


        [Fact]
        public async Task AvailableListingTypes()
        {
            var brands = await API.Users.AvailableListingTypes(new(userId: UserId));
        }

        
        [Fact]
        public async Task AvailableListingType()
        {
            var brands = await API.Users.AvailableListingType(new(userId: UserId));
        }

        [Fact]
        public async Task UsersApplications()
        {
            var brands = await API.Users.UsersApplications(new(userId: UserId));
        }

        [Fact]
        public async Task MissedFeeds()
        {
            var brands = await API.Users.MissedFeeds(new(userId: UserId));
        }
    }
}
