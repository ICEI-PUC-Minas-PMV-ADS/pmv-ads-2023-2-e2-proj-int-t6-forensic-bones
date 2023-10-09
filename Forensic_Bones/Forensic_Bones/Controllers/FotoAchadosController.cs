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
    public class FotoAchadosController : Controller
    {
        private readonly AppDbContext _context;

        public FotoAchadosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FotoAchados
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.FotografiasAchados.Include(f => f.InventEsqueleto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: FotoAchados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FotografiasAchados == null)
            {
                return NotFound();
            }

            var fotoAchado = await _context.FotografiasAchados
                .Include(f => f.InventEsqueleto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (fotoAchado == null)
            {
                return NotFound();
            }

            return View(fotoAchado);
        }

        // GET: FotoAchados/Create
        public IActionResult Create()
        {
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id");
            return View();
        }

        // POST: FotoAchados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,InventEsqueletoId,Url")] FotoAchado fotoAchado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fotoAchado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", fotoAchado.InventEsqueletoId);
            return View(fotoAchado);
        }

        // GET: FotoAchados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FotografiasAchados == null)
            {
                return NotFound();
            }

            var fotoAchado = await _context.FotografiasAchados.FindAsync(id);
            if (fotoAchado == null)
            {
                return NotFound();
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", fotoAchado.InventEsqueletoId);
            return View(fotoAchado);
        }

        // POST: FotoAchados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,InventEsqueletoId,Url")] FotoAchado fotoAchado)
        {
            if (id != fotoAchado.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fotoAchado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotoAchadoExists(fotoAchado.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", fotoAchado.InventEsqueletoId);
            return View(fotoAchado);
        }

        // GET: FotoAchados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FotografiasAchados == null)
            {
                return NotFound();
            }

            var fotoAchado = await _context.FotografiasAchados
                .Include(f => f.InventEsqueleto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (fotoAchado == null)
            {
                return NotFound();
            }

            return View(fotoAchado);
        }

        // POST: FotoAchados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FotografiasAchados == null)
            {
                return Problem("Entity set 'AppDbContext.FotografiasAchados'  is null.");
            }
            var fotoAchado = await _context.FotografiasAchados.FindAsync(id);
            if (fotoAchado != null)
            {
                _context.FotografiasAchados.Remove(fotoAchado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotoAchadoExists(int id)
        {
          return _context.FotografiasAchados.Any(e => e.id == id);
        }
    }
}
