using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Phoenicia;
using Xunit;

namespace Test
{
    public class WhenRegister
    {
        [Fact]
        public async void should_successfully_register_account_if_username_is_new()
        {
            var factory = new WebApplicationFactory<Startup>();
            var httpClient = factory.CreateClient();
            
            var user = new UserForRegister {Name = "name"};
            var stringUser = JsonConvert.SerializeObject(user);

            var apiResponse = await httpClient.PostAsync("/api/users/register",
                new StringContent(stringUser, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.Created, apiResponse.StatusCode);
        }
    }
}