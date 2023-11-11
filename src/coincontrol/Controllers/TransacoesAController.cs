using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models.TransacoesA;

namespace coincontrol.Controllers
{
    public class TransacoesAController : Controller
    {
        private readonly CoinControlBdContext _context;

        public TransacoesAController(CoinControlBdContext context)
        {
            _context = context;
        }

        // GET: TransacoesA
        public async Task<IActionResult> Index()
        {
            var dados = await _context.TransacoesA.ToListAsync();
            return View(dados);
        }

        // GET: TransacoesA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TransacoesA == null)
            {
                return NotFound();
            }

            var transacoesA = await _context.TransacoesA
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transacoesA == null)
            {
                return NotFound();
            }

            return View(transacoesA);
        }

        // GET: TransacoesA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransacoesA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransacao,IdUsuario,IdCarteira,Valor,Date,IdCategoria,Modalidade")] TransacoesA transacoesA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacoesA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transacoesA);
        }

        // GET: TransacoesA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TransacoesA == null)
            {
                return NotFound();
            }

            var transacoesA = await _context.TransacoesA.FindAsync(id);
            if (transacoesA == null)
            {
                return NotFound();
            }
            return View(transacoesA);
        }

        // POST: TransacoesA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransacao,IdUsuario,IdCarteira,Valor,Date,IdCategoria,Modalidade")] TransacoesA transacoesA)
        {
            if (id != transacoesA.IdTransacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacoesA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacoesAExists(transacoesA.IdTransacao))
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
            return View(transacoesA);
        }

        // GET: TransacoesA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransacoesA == null)
            {
                return NotFound();
            }

            var transacoesA = await _context.TransacoesA
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transacoesA == null)
            {
                return NotFound();
            }

            return View(transacoesA);
        }

        // POST: TransacoesA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransacoesA == null)
            {
                return Problem("Entity set 'CoinControlBdContext.TransacoesA'  is null.");
            }
            var transacoesA = await _context.TransacoesA.FindAsync(id);
            if (transacoesA != null)
            {
                _context.TransacoesA.Remove(transacoesA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransacoesAExists(int id)
        {
          return _context.TransacoesA.Any(e => e.IdTransacao == id);
        }
    }
}
