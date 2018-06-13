namespace Graphlax.Web.Api.Models.Request
{
    public class LoginRequestModel
        : BaseRequestModel
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
        public bool IsRemember { get; set; }
    }
}