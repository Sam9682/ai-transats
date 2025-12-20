using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TransactsWeb.Data;
using TransactsWeb.Models;

namespace TransactsWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string alias, string motDePasse)
        {
            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(motDePasse))
            {
                ViewBag.Error = "Veuillez saisir votre nom d'utilisateur et mot de passe";
                return View();
            }

            var employe = await _context.Employes
                .FirstOrDefaultAsync(e => e.Alias == alias && e.MotDePasse == motDePasse);

            if (employe != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, employe.Alias ?? ""),
                    new Claim(ClaimTypes.NameIdentifier, employe.NumEmploye.ToString()),
                    new Claim("FullName", $"{employe.PrenomEmploye} {employe.NomEmploye}"),
                    new Claim("Poste", employe.Poste ?? "")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(8)
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Nom d'utilisateur ou mot de passe incorrect";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}