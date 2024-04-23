using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using tekdostpatileri.Models;

namespace tekdostpatileri.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        TekDostPatileriDbContext db = new TekDostPatileriDbContext();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Giriş g)
        {
            var user = db.girişs.FirstOrDefault(x => x.KullanıcıAdı.Equals(g.KullanıcıAdı) && x.Şifre.Equals(g.Şifre));
            if (user != null)
            {

                var claims = new List<Claim>
                {
                  new Claim(ClaimTypes.Name, user.KullanıcıAdı),
                  new Claim(ClaimTypes.Email, user.KullanıcıAdı),
                  new Claim(ClaimTypes.Role, "Admin"),
                };

                var claimsIdentity = new ClaimsIdentity(
                     claims, CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.SignInAsync(
                     CookieAuthenticationDefaults.AuthenticationScheme,
                     new ClaimsPrincipal(claimsIdentity));

                return Redirect("~/Admin/AdminPaneli/Index");
            }
            else
            {
                return View();
            }

        }
    }
}
