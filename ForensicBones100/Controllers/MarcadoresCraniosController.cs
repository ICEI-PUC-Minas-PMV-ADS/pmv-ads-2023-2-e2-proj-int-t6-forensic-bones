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
            var appDbContext = _context.MarcadoresCranios.Include(m => m.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MarcadoresCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
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
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: MarcadoresCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarcadoresCranioId,RelatorioMarcadoresId,CristaNucal,CristaNucalDesc,ProcessoMastoide,ProcessoMastoideDesc," +
            "EminenciaMentoniana,EminenciaMentonianaDesc,SupraOrbital,SupraOrbitalDesc,AreaGlabela,AreaGlabelaDesc,CalculoEstimativaSexo")] MarcadoresCranio marcadoresCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcadoresCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarcadoresCranioId,RelatorioMarcadoresId,CristaNucal,CristaNucalDesc,ProcessoMastoide,ProcessoMastoideDesc," +
            "EminenciaMentoniana,EminenciaMentonianaDesc,SupraOrbital,SupraOrbitalDesc,AreaGlabela,AreaGlabelaDesc,CalculoEstimativaSexo")] MarcadoresCranio marcadoresCranio)
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
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
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
            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio != null)
            {
                _context.MarcadoresCranios.Remove(marcadoresCranio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcadoresCranioExists(int id)
        {
            return _context.MarcadoresCranios.Any(e => e.MarcadoresCranioId == id);
        }

        //calcula o sexo estimado

        [HttpPost]
        public IActionResult EstimarSexoAjax([FromBody] List<string> respostas)
        {
            // Conte a ocorrência de cada resposta
            var contagemMasculino = respostas.Count(r => r == "M");
            var contagemFeminino = respostas.Count(r => r == "F");
            var contagemInconclusivo = respostas.Count(r => r == "I");

            // Determine a resposta mais frequente
            var resultado = DeterminarResultado(contagemMasculino, contagemFeminino, contagemInconclusivo);

            // Retorne o resultado como JSON
            return Json(resultado);
        }

        private string DeterminarResultado(int contagemM, int contagemF, int contagemI)
        {
            // Implemente a lógica para determinar o resultado aqui
            // (use a lógica que você preferir)
            // Exemplo simples: retorne o valor mais frequente
            if (contagemM > contagemF && contagemM >= contagemI)
            {
                return "M";
            }
            else if (contagemF > contagemM && contagemF >= contagemI)
            {
                return "F";
            }
            else
            {
                return "I";
            }
        }

    }
}

