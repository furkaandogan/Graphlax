using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Graphlax.Web.Api.Controllers
{
    [Route("api/login")]
    public class LoginController
        : BaseController
    {
        public LoginController()
            :base()
        {
        }

        [HttpGet("")]
        public async Task<Models.Response.LoginResponseModel> Login([FromBody]Models.Request.LoginRequestModel data)
        {
            Models.Response.LoginResponseModel loginResponseModel=new Models.Response.LoginResponseModel();

            return loginResponseModel;
        }
    }
}