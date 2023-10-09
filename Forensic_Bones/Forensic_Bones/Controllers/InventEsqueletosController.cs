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
    public class InventEsqueletosController : Controller
    {
        private readonly AppDbContext _context;

        public InventEsqueletosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventEsqueletos
        public async Task<IActionResult> Index()
        {
              return View(await _context.InventarioEsqueleto.ToListAsync());
        }

        // GET: InventEsqueletos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventarioEsqueleto == null)
            {
                return NotFound();
            }

            var inventEsqueleto = await _context.InventarioEsqueleto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventEsqueleto);
        }

        // GET: InventEsqueletos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InventEsqueletos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuantidadeDeOssos,Data")] InventEsqueleto inventEsqueleto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventEsqueleto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventEsqueleto);
        }

        // GET: InventEsqueletos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventarioEsqueleto == null)
            {
                return NotFound();
            }

            var inventEsqueleto = await _context.InventarioEsqueleto.FindAsync(id);
            if (inventEsqueleto == null)
            {
                return NotFound();
            }
            return View(inventEsqueleto);
        }

        // POST: InventEsqueletos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuantidadeDeOssos,Data")] InventEsqueleto inventEsqueleto)
        {
            if (id != inventEsqueleto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventEsqueleto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventEsqueletoExists(inventEsqueleto.Id))
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
            return View(inventEsqueleto);
        }

        // GET: InventEsqueletos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventarioEsqueleto == null)
            {
                return NotFound();
            }

            var inventEsqueleto = await _context.InventarioEsqueleto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventEsqueleto);
        }

        // POST: InventEsqueletos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventarioEsqueleto == null)
            {
                return Problem("Entity set 'AppDbContext.InventarioEsqueleto'  is null.");
            }
            var inventEsqueleto = await _context.InventarioEsqueleto.FindAsync(id);
            if (inventEsqueleto != null)
            {
                _context.InventarioEsqueleto.Remove(inventEsqueleto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventEsqueletoExists(int id)
        {
          return _context.InventarioEsqueleto.Any(e => e.Id == id);
        }
    }
}
