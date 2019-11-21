using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test;

namespace Phoenicia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public object Register([FromBody] UserForRegister name)
        {
            return new ContentResult
            {
                StatusCode = (int?) HttpStatusCode.Created
            };
        }

        [HttpGet]
        [Route("/get")]
        public string Get()
        {
            return "success";
        }
    }
}