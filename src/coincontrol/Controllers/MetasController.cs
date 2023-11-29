using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models.Meta;
using System.Security.Claims;
using coincontrol.Models;

namespace coincontrol.Controllers
{
    public class MetasController : Controller
    {
        private readonly int MAX_METAS = 3; 
        private readonly CoinControlBdContext _context;

        public MetasController(CoinControlBdContext context)
        {
            _context = context;
        }

        // GET: Metas
        public async Task<IActionResult> Index()
        {
            var meta = _context.Metas.Include(m => m.Categoria);
            return View(await meta.ToListAsync());
        }

        // GET: Metas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Metas == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas
                .FirstOrDefaultAsync(m => m.IdMeta == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // GET: Metas/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = _context.Categories.Where(c => c.Modalidade == "Meta").ToList();
            return View();
        }

        // POST: Metas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ValorTotal,IdCategoria")] Meta meta)
        {
            var emailUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == emailUsuario);

            var metasUsuario = await _context.Metas
                .Where(m => m.Usuario == usuario)
                .ToListAsync();

            if (metasUsuario.Count > MAX_METAS)
            {
                ModelState.AddModelError(string.Empty, "Número máximo de metas atingidas!");
                return View(meta);
            }

            if (ModelState.IsValid)
            {
                int idCategoria;
                if (int.TryParse(HttpContext.Request.Form["IdCategoria"], out idCategoria))
                {
                    var categoria = await _context.Categories.FindAsync(idCategoria);
                    meta.Categoria = categoria;
                }

                meta.Usuario = usuario;
                metasUsuario.Add(meta);
                _context.Add(meta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meta);
        }

        // GET: Metas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Metas == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas.FindAsync(id);
            if (meta == null)
            {
                return NotFound();
            }
            return View(meta);
        }

        // POST: Metas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("IdMeta,ValorTotal,ValorParcial")] Meta meta)
        {
            if (id != meta.IdMeta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(meta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meta);
        }

        // GET: Metas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Metas == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas
                .FirstOrDefaultAsync(m => m.IdMeta == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // POST: Metas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Metas == null)
            {
                return Problem("Entity set 'CoinControlBdContext.Meta'  is null.");
            }
            var meta = await _context.Metas.FindAsync(id);
            if (meta != null)
            {
                _context.Metas.Remove(meta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetaExists(int id)
        {
          return _context.Metas.Any(e => e.IdMeta == id);
        }
    }
}
