using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SailingPeople.Domain;
using SailingPeople.Models; // LoginViewModel'in olduğu namespace
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace SailingPeople.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.Users
                .SingleOrDefaultAsync(x => x.Username == model.Username);

            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı!");
                return View(model);
            }

            if (user.Password != model.Password)
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                claimsPrincipal
            );

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}
