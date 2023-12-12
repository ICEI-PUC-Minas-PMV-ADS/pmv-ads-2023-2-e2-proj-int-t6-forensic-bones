using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones100.Models;
using Microsoft.AspNetCore.Authorization;

namespace ForensicBones100.Controllers
{
    [Authorize]
    public class InventariosCranioController : Controller
    {
        private readonly AppDbContext _context;

        public InventariosCranioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventariosCranio
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventariosCranio.Include(i => i.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventariosCranio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Create
        public IActionResult Create()
        {
            ViewData["RelatorioCranioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: InventariosCranio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioCranioId,RelatorioCranioId,Frontal,FrontalDesc,Ocipital,OcipitalDesc,Esfenoide,EsfenoideDesc,Maxilar,MaxilarDesc,Vomer,VomerDesc,ParietalEsquerdo,ParietalEsquerdoDesc,TemporalEsquerdo,TemporalEsquerdoDesc,ConchaNasalInferiorEsquerda,ConchaNasalInferiorEsquerdaDesc,Etmoide,EtmoideDesc,LacrimalEsquerdo,LacrimalEsquerdoDesc,NasalEsquerdo,NasalEsquerdoDesc,ZigomaticoEsquerdo,ZigomaticoEsquerdoDesc,ParietalDireito,ParietalDireitoDesc,TemporalDireito,TemporalDireitoDesc,ConchaNasalInferiorDireita,ConchaNasalInferiorDireitaDesc,LacrimalDireito,LacrimalDireitoDesc,NasalDireito,NasalDireitoDesc,ZigomaticoDireito,ZigomaticoDireitoDesc,Hioide,HioideDesc,CartilagemTireoide,CartilagemTireoideDesc,Mandibula,MandibulaDesc,Observacoes,FotosCranio")] InventarioCranio inventarioCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "MarcadoresCranios");
            }
            ViewData["RelatorioCranioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioCranioId);
            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio.FindAsync(id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }
            ViewData["RelatorioCranioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioCranioId);
            return View(inventarioCranio);
        }

        // POST: InventariosCranio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioCranioId,RelatorioCranioId,Frontal,FrontalDesc,Ocipital,OcipitalDesc,Esfenoide,EsfenoideDesc,Maxilar,MaxilarDesc,Vomer,VomerDesc,ParietalEsquerdo,ParietalEsquerdoDesc,TemporalEsquerdo,TemporalEsquerdoDesc,ConchaNasalInferiorEsquerda,ConchaNasalInferiorEsquerdaDesc,Etmoide,EtmoideDesc,LacrimalEsquerdo,LacrimalEsquerdoDesc,NasalEsquerdo,NasalEsquerdoDesc,ZigomaticoEsquerdo,ZigomaticoEsquerdoDesc,ParietalDireito,ParietalDireitoDesc,TemporalDireito,TemporalDireitoDesc,ConchaNasalInferiorDireita,ConchaNasalInferiorDireitaDesc,LacrimalDireito,LacrimalDireitoDesc,NasalDireito,NasalDireitoDesc,ZigomaticoDireito,ZigomaticoDireitoDesc,Hioide,HioideDesc,CartilagemTireoide,CartilagemTireoideDesc,Mandibula,MandibulaDesc,Observacoes,FotosCranio")] InventarioCranio inventarioCranio)
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
            ViewData["RelatorioCranioId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", inventarioCranio.RelatorioCranioId);
            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // POST: InventariosCranio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventarioCranio = await _context.InventariosCranio.FindAsync(id);
            if (inventarioCranio != null)
            {
                _context.InventariosCranio.Remove(inventarioCranio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioCranioExists(int id)
        {
            return _context.InventariosCranio.Any(e => e.InventarioCranioId == id);
        }
    }
}
