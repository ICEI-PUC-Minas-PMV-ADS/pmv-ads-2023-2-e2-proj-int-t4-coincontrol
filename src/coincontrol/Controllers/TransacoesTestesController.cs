using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models.TransacoesTestes;

namespace coincontrol.Controllers
{
    public class TransacoesTestesController : Controller
    {
        private readonly CoinControlBdContext _context;

        public TransacoesTestesController(CoinControlBdContext context)
        {
            _context = context;
        }

        // GET: TransacoesTestes
        public async Task<IActionResult> Index()
        {
              return View(await _context.TransacaoTeste.ToListAsync());
        }

        // GET: TransacoesTestes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TransacaoTeste == null)
            {
                return NotFound();
            }

            var transacaoTeste = await _context.TransacaoTeste
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transacaoTeste == null)
            {
                return NotFound();
            }

            return View(transacaoTeste);
        }

        // GET: TransacoesTestes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransacoesTestes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCarteira,Valor,Date,IdCategoria,Modalidade")] TransacaoTeste transacaoTeste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacaoTeste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transacaoTeste);
        }

        // GET: TransacoesTestes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TransacaoTeste == null)
            {
                return NotFound();
            }

            var transacaoTeste = await _context.TransacaoTeste.FindAsync(id);
            if (transacaoTeste == null)
            {
                return NotFound();
            }
            return View(transacaoTeste);
        }

        // POST: TransacoesTestes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCarteira,Valor,Date,IdCategoria,Modalidade")] TransacaoTeste transacaoTeste)
        {
            if (id != transacaoTeste.IdTransacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacaoTeste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacaoTesteExists(transacaoTeste.IdTransacao))
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
            return View(transacaoTeste);
        }

        // GET: TransacoesTestes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransacaoTeste == null)
            {
                return NotFound();
            }

            var transacaoTeste = await _context.TransacaoTeste
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transacaoTeste == null)
            {
                return NotFound();
            }

            return View(transacaoTeste);
        }

        // POST: TransacoesTestes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransacaoTeste == null)
            {
                return Problem("Entity set 'CoinControlBdContext.TransacaoTeste'  is null.");
            }
            var transacaoTeste = await _context.TransacaoTeste.FindAsync(id);
            if (transacaoTeste != null)
            {
                _context.TransacaoTeste.Remove(transacaoTeste);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransacaoTesteExists(int id)
        {
          return _context.TransacaoTeste.Any(e => e.IdTransacao == id);
        }
    }
}
