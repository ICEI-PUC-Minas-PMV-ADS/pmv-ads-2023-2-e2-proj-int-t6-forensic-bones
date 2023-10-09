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
    public class MarcadorCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public MarcadorCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MarcadorCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.MarcadoresCranio.Include(m => m.InventCranio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MarcadorCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadorCranio = await _context.MarcadoresCranio
                .Include(m => m.InventCranio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marcadorCranio == null)
            {
                return NotFound();
            }

            return View(marcadorCranio);
        }

        // GET: MarcadorCranios/Create
        public IActionResult Create()
        {
            ViewData["InventCranioId"] = new SelectList(_context.InventarioCranio, "Id", "Id");
            return View();
        }

        // POST: MarcadorCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InventCranioId,CristalNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,Observacoes")] MarcadorCranio marcadorCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcadorCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventCranioId"] = new SelectList(_context.InventarioCranio, "Id", "Id", marcadorCranio.InventCranioId);
            return View(marcadorCranio);
        }

        // GET: MarcadorCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadorCranio = await _context.MarcadoresCranio.FindAsync(id);
            if (marcadorCranio == null)
            {
                return NotFound();
            }
            ViewData["InventCranioId"] = new SelectList(_context.InventarioCranio, "Id", "Id", marcadorCranio.InventCranioId);
            return View(marcadorCranio);
        }

        // POST: MarcadorCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InventCranioId,CristalNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,Observacoes")] MarcadorCranio marcadorCranio)
        {
            if (id != marcadorCranio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcadorCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcadorCranioExists(marcadorCranio.Id))
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
            ViewData["InventCranioId"] = new SelectList(_context.InventarioCranio, "Id", "Id", marcadorCranio.InventCranioId);
            return View(marcadorCranio);
        }

        // GET: MarcadorCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadorCranio = await _context.MarcadoresCranio
                .Include(m => m.InventCranio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marcadorCranio == null)
            {
                return NotFound();
            }

            return View(marcadorCranio);
        }

        // POST: MarcadorCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MarcadoresCranio == null)
            {
                return Problem("Entity set 'AppDbContext.MarcadoresCranio'  is null.");
            }
            var marcadorCranio = await _context.MarcadoresCranio.FindAsync(id);
            if (marcadorCranio != null)
            {
                _context.MarcadoresCranio.Remove(marcadorCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcadorCranioExists(int id)
        {
          return _context.MarcadoresCranio.Any(e => e.Id == id);
        }
    }
}
