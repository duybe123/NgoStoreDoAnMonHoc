using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace NguyenVinhDuy.Web.Controllers
{
    public  class AuthenticationController:Controller
    {
        [Route("/authenticate")]
        public async Task<IActionResult> Authenticate([FromQuery]string user, [FromQuery]string password)
        {
            if(user =="admin" && password == "admin")
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user),
                    new Claim(ClaimTypes.Email,"admin@eshop.com"),
                    new Claim(ClaimTypes.HomePhone,"0123456789")
                };
                var userIdentity=new ClaimsIdentity(userClaims,"eShop.CookieAuth");
                var userPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync("eShop.CookieAuth", userPrincipal);
            }
            return Redirect("/outstadingorders");
        }
        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/outstadingorders");
        }
    }
}
