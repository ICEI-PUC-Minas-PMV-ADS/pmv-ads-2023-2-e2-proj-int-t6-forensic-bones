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
    public class InventarioCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public InventarioCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventarioCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventarioCranio.Include(i => i.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventarioCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Create
        public IActionResult Create()
        {
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: InventarioCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioCranioId,RelatorioId,InventarioEsqueletoId,FotoCranio,Observacoes,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula,FrontalDesc,OcipitalDesc,EsfenoideDesc,MaxilarDesc,VomerDesc,ParietalEsqDesc,TemporalEsqDesc,ConchaNasalEsqDesc,EtmoideEsqDesc,LacrimalEsqDesc,NasalEsqDesc,ZigomaticoEsqDesc,ParietalDirDesc,TemporalDirDesc,ConchaNasalDirDesc,EtmoideDirDesc,LacrimalDirDesc,ZigomaticoDirDesc,HioideDesc,CartilagemTireoideDesc,MandibulaDesc")] InventarioCranio inventarioCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioId);
            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioId);
            return View(inventarioCranio);
        }

        // POST: InventarioCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioCranioId,RelatorioId,InventarioEsqueletoId,FotoCranio,Observacoes,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula,FrontalDesc,OcipitalDesc,EsfenoideDesc,MaxilarDesc,VomerDesc,ParietalEsqDesc,TemporalEsqDesc,ConchaNasalEsqDesc,EtmoideEsqDesc,LacrimalEsqDesc,NasalEsqDesc,ZigomaticoEsqDesc,ParietalDirDesc,TemporalDirDesc,ConchaNasalDirDesc,EtmoideDirDesc,LacrimalDirDesc,ZigomaticoDirDesc,HioideDesc,CartilagemTireoideDesc,MandibulaDesc")] InventarioCranio inventarioCranio)
        {
            if (id != inventarioCranio.InventarioCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioCranioExists(inventarioCranio.InventarioCranioId))
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
            ViewData["RelatorioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioId);
            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventarioCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // POST: InventarioCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventarioCranio == null)
            {
                return Problem("Entity set 'AppDbContext.InventarioCranio'  is null.");
            }
            var inventarioCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventarioCranio != null)
            {
                _context.InventarioCranio.Remove(inventarioCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioCranioExists(int id)
        {
          return _context.InventarioCranio.Any(e => e.InventarioCranioId == id);
        }
    }
}
