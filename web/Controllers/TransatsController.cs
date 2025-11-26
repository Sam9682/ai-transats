using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using TransactsWeb.Models;

namespace TransactsWeb.Controllers
{
    [Authorize]
    public class TransatsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransatsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var transats = await _context.Transats
                .Include(t => t.Reservations)
                .ThenInclude(r => r.Client)
                .ToListAsync();

            var reservationsToday = await _context.ReservTransats
                .Where(r => r.DateReservation.Date == DateTime.Today)
                .Include(r => r.Client)
                .Include(r => r.Transat)
                .ToListAsync();

            ViewBag.ReservationsToday = reservationsToday;
            return View(transats);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransat(int posX, int posY)
        {
            var maxNum = await _context.Transats.MaxAsync(t => (int?)t.NumTransat) ?? 0;
            
            var transat = new Transat
            {
                NumTransat = maxNum + 1,
                PosX = posX,
                PosY = posY,
                EtatCourant = 0
            };

            _context.Transats.Add(transat);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePosition(int transatId, int newX, int newY)
        {
            var transat = await _context.Transats.FindAsync(transatId);
            if (transat != null)
            {
                transat.PosX = newX;
                transat.PosY = newY;
                await _context.SaveChangesAsync();
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Reserve(int transatId, int clientId, DateTime dateReservation)
        {
            var reservation = new ReservTransat
            {
                NumTransat = transatId,
                NumClient = clientId,
                DateReservation = dateReservation
            };

            var transat = await _context.Transats.FindAsync(transatId);
            if (transat != null)
            {
                transat.EtatCourant = 1; // Réservé
            }

            _context.ReservTransats.Add(reservation);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Occupy(int transatId)
        {
            var transat = await _context.Transats.FindAsync(transatId);
            if (transat != null)
            {
                transat.EtatCourant = 2; // Occupé
                await _context.SaveChangesAsync();
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Free(int transatId)
        {
            var transat = await _context.Transats.FindAsync(transatId);
            if (transat != null)
            {
                transat.EtatCourant = 0; // Libre
                await _context.SaveChangesAsync();
            }

            return Json(new { success = true });
        }

        public async Task<IActionResult> GetClients()
        {
            var clients = await _context.Clients
                .Select(c => new { c.NumClient, Name = $"{c.PrenomClient} {c.NomClient}" })
                .ToListAsync();

            return Json(clients);
        }
    }
}