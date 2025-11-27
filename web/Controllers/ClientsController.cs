using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using TransactsWeb.Models;

namespace TransactsWeb.Controllers
{
    [Authorize]
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string search = "", string searchType = "NumClient")
        {
            var clients = _context.Clients.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                switch (searchType)
                {
                    case "NomClient":
                        clients = clients.Where(c => c.NomClient.Contains(search));
                        break;
                    case "PrenomClient":
                        clients = clients.Where(c => c.PrenomClient.Contains(search));
                        break;
                    default:
                        if (int.TryParse(search, out int numClient))
                            clients = clients.Where(c => c.NumClient == numClient);
                        break;
                }
            }

            ViewBag.Search = search;
            ViewBag.SearchType = searchType;
            return View(await clients.ToListAsync());
        }

        public IActionResult Create()
        {
            Console.WriteLine("[CLIENTS] Create page requested");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Client client)
        {
            Console.WriteLine($"[CLIENTS] Creating client: {client.NomClient} {client.PrenomClient}");
            if (ModelState.IsValid)
            {
                _context.Clients.Add(client);
                await _context.SaveChangesAsync();
                Console.WriteLine($"[CLIENTS] Client created successfully with ID: {client.NumClient}");
                return RedirectToAction(nameof(Index));
            }
            Console.WriteLine("[CLIENTS] Create failed - ModelState invalid");
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"[CLIENTS] Validation error: {error.ErrorMessage}");
            }
            return View(client);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
                return NotFound();
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Update(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateAccount(int clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);
            if (client == null)
                return NotFound();

            var compte = new CompteJournalier
            {
                RefClient = clientId,
                DateOuvertureCompte = DateTime.Now
            };

            _context.ComptesJournaliers.Add(compte);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}