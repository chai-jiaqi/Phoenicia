using System.Net;
using System.Net.Http;
using Xunit;

namespace Test
{
    public class WhenRegister
    {
        private const string ApiBaseUrl = "http://localhost:5000";
        
        [Fact]
        public async void should_successfully_register_account_if_username_is_new()
        {
            var httpClient = new HttpClient();
            
            var apiResponse = await httpClient.GetAsync($"{ApiBaseUrl}/register");
 
            Assert.Equal(HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        public async void should_return_bad_request_if_username_duplicate()
        {
            var httpClient = new HttpClient();
            
            var apiResponse = await httpClient.GetAsync($"{ApiBaseUrl}/register");
 
            Assert.Equal(HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }
    }
}