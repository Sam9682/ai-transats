using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using TransactsWeb.Models;

namespace TransactsWeb.Controllers
{
    [Authorize]
    public class EmployesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Console.WriteLine("[EMPLOYES] Index page requested");
            var employes = await _context.Employes.ToListAsync();
            Console.WriteLine($"[EMPLOYES] Found {employes.Count} employees");
            return View(employes);
        }

        public IActionResult Create()
        {
            Console.WriteLine("[EMPLOYES] Create page requested");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employe employe)
        {
            Console.WriteLine($"[EMPLOYES] Creating employee: {employe.NomEmploye} {employe.PrenomEmploye}");
            if (ModelState.IsValid)
            {
                _context.Add(employe);
                await _context.SaveChangesAsync();
                Console.WriteLine($"[EMPLOYES] Employee created successfully with ID: {employe.NumEmploye}");
                return RedirectToAction(nameof(Index));
            }
            Console.WriteLine("[EMPLOYES] Create failed - ModelState invalid");
            return View(employe);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            Console.WriteLine($"[EMPLOYES] Edit page requested for ID: {id}");
            if (id == null) return NotFound();
            var employe = await _context.Employes.FindAsync(id);
            if (employe == null)
            {
                Console.WriteLine($"[EMPLOYES] Employee not found: {id}");
                return NotFound();
            }
            return View(employe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employe employe)
        {
            Console.WriteLine($"[EMPLOYES] Updating employee ID: {id}");
            if (id != employe.NumEmploye) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(employe);
                await _context.SaveChangesAsync();
                Console.WriteLine($"[EMPLOYES] Employee updated successfully: {id}");
                return RedirectToAction(nameof(Index));
            }
            Console.WriteLine("[EMPLOYES] Update failed - ModelState invalid");
            return View(employe);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            Console.WriteLine($"[EMPLOYES] Delete requested for ID: {id}");
            if (id == null) return NotFound();
            var employe = await _context.Employes.FindAsync(id);
            if (employe == null)
            {
                Console.WriteLine($"[EMPLOYES] Employee not found: {id}");
                return NotFound();
            }
            _context.Employes.Remove(employe);
            await _context.SaveChangesAsync();
            Console.WriteLine($"[EMPLOYES] Employee deleted successfully: {id}");
            return RedirectToAction(nameof(Index));
        }
    }
}
