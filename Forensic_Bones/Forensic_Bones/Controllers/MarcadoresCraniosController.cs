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
    public class MarcadoresCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public MarcadoresCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MarcadoresCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.MarcadoresCranio.Include(m => m.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MarcadoresCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranio
                .Include(m => m.Relatorio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Create
        public IActionResult Create()
        {
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: MarcadoresCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarcadoresCranioId,RelatorioId,CristaNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,Observacoes")] MarcadoresCranio marcadoresCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcadoresCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranio.FindAsync(id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioId);
            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarcadoresCranioId,RelatorioId,CristaNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,Observacoes")] MarcadoresCranio marcadoresCranio)
        {
            if (id != marcadoresCranio.MarcadoresCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcadoresCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcadoresCranioExists(marcadoresCranio.MarcadoresCranioId))
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
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MarcadoresCranio == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranio
                .Include(m => m.Relatorio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MarcadoresCranio == null)
            {
                return Problem("Entity set 'AppDbContext.MarcadoresCranio'  is null.");
            }
            var marcadoresCranio = await _context.MarcadoresCranio.FindAsync(id);
            if (marcadoresCranio != null)
            {
                _context.MarcadoresCranio.Remove(marcadoresCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcadoresCranioExists(int id)
        {
          return _context.MarcadoresCranio.Any(e => e.MarcadoresCranioId == id);
        }
    }
}
