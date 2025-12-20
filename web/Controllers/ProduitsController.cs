using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using TransactsWeb.Models;

namespace TransactsWeb.Controllers
{
    [Authorize]
    public class ProduitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProduitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string type = "Restaurant")
        {
            var produits = await _context.Produits
                .Where(p => p.TypeProduit == type)
                .ToListAsync();

            ViewBag.Type = type;
            ViewBag.Title = GetTitle(type);
            return View(produits);
        }

        private string GetTitle(string type)
        {
            return type switch
            {
                "Restaurant" => "Gestion Restaurant",
                "Bar" => "Gestion Bar",
                "Snack" => "Gestion Snack",
                "Boutique" => "Gestion Boutique",
                "BaseNautique" => "Base Nautique",
                _ => "Gestion Produits"
            };
        }

        public IActionResult Create(string type = "Restaurant")
        {
            ViewBag.Type = type;
            return View(new Produit { TypeProduit = type });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Produits.Add(produit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { type = produit.TypeProduit });
            }
            ViewBag.Type = produit.TypeProduit;
            return View(produit);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var produit = await _context.Produits.FindAsync(id);
            if (produit == null)
                return NotFound();
            
            ViewBag.Type = produit.TypeProduit;
            return View(produit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Update(produit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { type = produit.TypeProduit });
            }
            ViewBag.Type = produit.TypeProduit;
            return View(produit);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var produit = await _context.Produits.FindAsync(id);
            if (produit != null)
            {
                var type = produit.TypeProduit;
                _context.Produits.Remove(produit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { type });
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ToggleDisponibilite(int id)
        {
            var produit = await _context.Produits.FindAsync(id);
            if (produit != null)
            {
                produit.Disponible = !produit.Disponible;
                await _context.SaveChangesAsync();
            }
            return Json(new { success = true });
        }
    }
}