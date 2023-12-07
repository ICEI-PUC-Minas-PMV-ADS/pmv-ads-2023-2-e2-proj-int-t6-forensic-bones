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
    public class InventarioEsqueletosController : Controller
    {
        private readonly AppDbContext _context;

        public InventarioEsqueletosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventarioEsqueletos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventariosEsqueleto.Include(i => i.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventarioEsqueletos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventariosEsqueleto == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventariosEsqueleto
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioEsqueletoId == id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletos/Create
        public IActionResult Create()
        {
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: InventarioEsqueletos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioEsqueletoId,RelatorioId,FotoEsqueleto,ObservacoesEsq")] InventarioEsqueleto inventarioEsqueleto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioEsqueleto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioEsqueleto.RelatorioId);
            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventariosEsqueleto == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventariosEsqueleto.FindAsync(id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioEsqueleto.RelatorioId);
            return View(inventarioEsqueleto);
        }

        // POST: InventarioEsqueletos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioEsqueletoId,RelatorioId,FotoEsqueleto,ObservacoesEsq")] InventarioEsqueleto inventarioEsqueleto)
        {
            if (id != inventarioEsqueleto.InventarioEsqueletoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioEsqueleto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioEsqueletoExists(inventarioEsqueleto.InventarioEsqueletoId))
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
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioEsqueleto.RelatorioId);
            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventariosEsqueleto == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventariosEsqueleto
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioEsqueletoId == id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventarioEsqueleto);
        }

        // POST: InventarioEsqueletos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventariosEsqueleto == null)
            {
                return Problem("Entity set 'AppDbContext.InventariosEsqueleto'  is null.");
            }
            var inventarioEsqueleto = await _context.InventariosEsqueleto.FindAsync(id);
            if (inventarioEsqueleto != null)
            {
                _context.InventariosEsqueleto.Remove(inventarioEsqueleto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioEsqueletoExists(int id)
        {
          return _context.InventariosEsqueleto.Any(e => e.InventarioEsqueletoId == id);
        }
    }
}
