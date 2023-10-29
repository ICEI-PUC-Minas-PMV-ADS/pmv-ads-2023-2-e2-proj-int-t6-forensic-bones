using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forensic_Bones.Models;

namespace Forensic_Bones.Controllers
{
    public class FotoEsqueletosController : Controller
    {
        private readonly AppDbContext _context;

        public FotoEsqueletosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FotoEsqueletos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.FotografiasEsqueleto.Include(f => f.InventEsqueleto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: FotoEsqueletos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FotografiasEsqueleto == null)
            {
                return NotFound();
            }

            var fotoEsqueleto = await _context.FotografiasEsqueleto
                .Include(f => f.InventEsqueleto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (fotoEsqueleto == null)
            {
                return NotFound();
            }

            return View(fotoEsqueleto);
        }

                _context.Add(fotoEsqueleto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", fotoEsqueleto.InventEsqueletoId);
            return View(fotoEsqueleto);
        }

        // GET: FotoEsqueletos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FotografiasEsqueleto == null)
            {
                return NotFound();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,InventEsqueletoId,Url")] FotoEsqueleto fotoEsqueleto)
        {
            if (id != fotoEsqueleto.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fotoEsqueleto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotoEsqueletoExists(fotoEsqueleto.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", fotoEsqueleto.InventEsqueletoId);
            return View(fotoEsqueleto);
        }

        // POST: FotoEsqueletos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FotografiasEsqueleto == null)
            {
                return Problem("Entity set 'AppDbContext.FotografiasEsqueleto'  is null.");
            }
            var fotoEsqueleto = await _context.FotografiasEsqueleto.FindAsync(id);
            if (fotoEsqueleto != null)
            {
                _context.FotografiasEsqueleto.Remove(fotoEsqueleto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

}
