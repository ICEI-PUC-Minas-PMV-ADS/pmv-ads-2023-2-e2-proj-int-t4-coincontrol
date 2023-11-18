using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models.Carteira;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace coincontrol.Controllers
{
    [Authorize]
    public class CarteiraController : Controller
    {
        private readonly CoinControlBdContext _context;

        public CarteiraController(CoinControlBdContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var carteiras = _context.Carteira.ToList();
            return View(carteiras);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Carteira novaCarteira)
        {
            var emailUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == emailUsuario);

            if (usuario != null)
            {
                novaCarteira.idUsuario = usuario.idUsuario;

                if (ModelState.IsValid)
                {
                    _context.Carteira.Add(novaCarteira);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
            }

            return View(novaCarteira);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carteira = _context.Carteira.FirstOrDefault(c => c.idCarteira == id);

            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCarteira,saldoInicial, ano, mes")] Carteira carteira)
        {
            if (id != carteira.idCarteira)
            {
                return NotFound();
            }

           
            var existingCarteira = await _context.Carteira.FindAsync(id);
            if (existingCarteira == null)
            {
                return NotFound();
            }

            
            _context.Entry(existingCarteira).State = EntityState.Detached;

            var emailUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == emailUsuario);
            if (usuario == null)
            {
                ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
                return View(carteira);
            }

            existingCarteira.saldoInicial = carteira.saldoInicial;
            existingCarteira.ano = carteira.ano;
            existingCarteira.mes = carteira.mes;
            existingCarteira.idUsuario = usuario.idUsuario;

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarteiraExists(id))
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

            ModelState.AddModelError(string.Empty, "Ocorreu um erro ao editar a carteira.");
            return View(carteira);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Carteira == null)
            {
                return NotFound();
            }

            var carteira = await _context.Carteira
                .FirstOrDefaultAsync(c => c.idCarteira == id);

            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Carteira == null)
            {
                return Problem("Entity set 'CoinControlBdContext.Carteira' is null.");
            }

            var carteira = await _context.Carteira.FindAsync(id);

            if (carteira != null)
            {
                _context.Carteira.Remove(carteira);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool CarteiraExists(int id)
        {
            return _context.Carteira.Any(c => c.idCarteira == id);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carteira = _context.Carteira.FirstOrDefault(c => c.idCarteira == id);

            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")] 
        public IActionResult EscolherAnos(int anoEscolhido)
        {
            var anos = Enumerable.Range(DateTime.Now.Year - 9, 10).ToList();
            ViewBag.Anos = new SelectList(anos, anoEscolhido);

            return View();
        }
    }
}
