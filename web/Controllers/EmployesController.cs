using System.Runtime.CompilerServices;
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
            ConsoleLogger.WriteLine("[EMPLOYES] Index page requested");
            var employes = await _context.Employes.ToListAsync();
            ConsoleLogger.WriteLine($"[EMPLOYES] Found {employes.Count} employees");
            return View(employes);
        }

        public IActionResult Create()
        {
            ConsoleLogger.WriteLine("[EMPLOYES] Create page requested");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employe employe)
        {
            ConsoleLogger.WriteLine($"[EMPLOYES] Creating employee: {employe.NomEmploye} {employe.PrenomEmploye}");
            if (ModelState.IsValid)
            {
                _context.Add(employe);
                await _context.SaveChangesAsync();
                ConsoleLogger.WriteLine($"[EMPLOYES] Employee created successfully with ID: {employe.NumEmploye}");
                return RedirectToAction(nameof(Index));
            }
            ConsoleLogger.WriteLine("[EMPLOYES] Create failed - ModelState invalid");
            return View(employe);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ConsoleLogger.WriteLine($"[EMPLOYES] Edit page requested for ID: {id}");
            if (id == null) return NotFound();
            var employe = await _context.Employes.FindAsync(id);
            if (employe == null)
            {
                ConsoleLogger.WriteLine($"[EMPLOYES] Employee not found: {id}");
                return NotFound();
            }
            return View(employe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employe employe)
        {
            ConsoleLogger.WriteLine($"[EMPLOYES] Updating employee ID: {id}");
            if (id != employe.NumEmploye) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(employe);
                await _context.SaveChangesAsync();
                ConsoleLogger.WriteLine($"[EMPLOYES] Employee updated successfully: {id}");
                return RedirectToAction(nameof(Index));
            }
            ConsoleLogger.WriteLine("[EMPLOYES] Update failed - ModelState invalid");
            return View(employe);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            ConsoleLogger.WriteLine($"[EMPLOYES] Delete requested for ID: {id}");
            if (id == null) return NotFound();
            var employe = await _context.Employes.FindAsync(id);
            if (employe == null)
            {
                ConsoleLogger.WriteLine($"[EMPLOYES] Employee not found: {id}");
                return NotFound();
            }
            _context.Employes.Remove(employe);
            await _context.SaveChangesAsync();
            ConsoleLogger.WriteLine($"[EMPLOYES] Employee deleted successfully: {id}");
            return RedirectToAction(nameof(Index));
        }
    }
}
