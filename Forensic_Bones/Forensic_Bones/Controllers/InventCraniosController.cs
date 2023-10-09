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
    public class InventCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public InventCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventarioCranio.Include(i => i.InventEsqueleto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventCranio = await _context.InventarioCranio
                .Include(i => i.InventEsqueleto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventCranio == null)
            {
                return NotFound();
            }

            return View(inventCranio);
        }

        // GET: InventCranios/Create
        public IActionResult Create()
        {
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id");
            return View();
        }

        // POST: InventCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InventEsqueletoId,Descricao,Frontal,Ocipital,Esfenoide,Maxilar,Palatino,Vomer,ParietalEsquerdo,TemporalEsquerdo,ConchaNasalInferiorEsquerda,EtmoideEsquerdo,LacrimalEsquerdo,NasalEsquerdo,ZigomaticoEsquerdo,ParietalDireito,TemporalDireito,ConchaNasalInferiorDireita,Etmoide,LacrimalDireito,ZigomaticoDireito,Hioide,CartilagemDaTireoide,Mandibula")] InventCranio inventCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", inventCranio.InventEsqueletoId);
            return View(inventCranio);
        }

        // GET: InventCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventCranio == null)
            {
                return NotFound();
            }
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", inventCranio.InventEsqueletoId);
            return View(inventCranio);
        }

        // POST: InventCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InventEsqueletoId,Descricao,Frontal,Ocipital,Esfenoide,Maxilar,Palatino,Vomer,ParietalEsquerdo,TemporalEsquerdo,ConchaNasalInferiorEsquerda,EtmoideEsquerdo,LacrimalEsquerdo,NasalEsquerdo,ZigomaticoEsquerdo,ParietalDireito,TemporalDireito,ConchaNasalInferiorDireita,Etmoide,LacrimalDireito,ZigomaticoDireito,Hioide,CartilagemDaTireoide,Mandibula")] InventCranio inventCranio)
        {
            if (id != inventCranio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventCranioExists(inventCranio.Id))
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
            ViewData["InventEsqueletoId"] = new SelectList(_context.InventarioEsqueleto, "Id", "Id", inventCranio.InventEsqueletoId);
            return View(inventCranio);
        }

        // GET: InventCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventCranio = await _context.InventarioCranio
                .Include(i => i.InventEsqueleto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventCranio == null)
            {
                return NotFound();
            }

            return View(inventCranio);
        }

        // POST: InventCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventarioCranio == null)
            {
                return Problem("Entity set 'AppDbContext.InventarioCranio'  is null.");
            }
            var inventCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventCranio != null)
            {
                _context.InventarioCranio.Remove(inventCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventCranioExists(int id)
        {
          return _context.InventarioCranio.Any(e => e.Id == id);
        }
    }
}
