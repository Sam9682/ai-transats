using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TransactsWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace TransactsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // If user is not authenticated, redirect to login
            if (!User.Identity?.IsAuthenticated ?? true)
            {
                return RedirectToAction("Login", "Account");
            }

            var stats = new
            {
                TotalClients = await _context.Clients.CountAsync(),
                TotalTransats = await _context.Transats.CountAsync(),
                TransatsLibres = await _context.Transats.CountAsync(t => t.EtatCourant == 0),
                ReservationsAujourdhui = await _context.ReservTransats.CountAsync(r => r.DateReservation.Date == DateTime.Today)
            };

            ViewBag.Stats = stats;
            return View();
        }

        [Authorize]
        public IActionResult Plage()
        {
            return RedirectToAction("Index", "Transats");
        }

        [Authorize]
        public IActionResult Restaurant()
        {
            return RedirectToAction("Index", "Produits", new { type = "Restaurant" });
        }

        [Authorize]
        public IActionResult Bar()
        {
            return RedirectToAction("Index", "Produits", new { type = "Bar" });
        }

        [Authorize]
        public IActionResult Snack()
        {
            return RedirectToAction("Index", "Produits", new { type = "Snack" });
        }

        [Authorize]
        public IActionResult Boutique()
        {
            return RedirectToAction("Index", "Produits", new { type = "Boutique" });
        }

        [Authorize]
        public IActionResult BaseNautique()
        {
            return RedirectToAction("Index", "Produits", new { type = "BaseNautique" });
        }
    }
}