using BCrypt.Net;
using coincontrol.CCDbContext;
using coincontrol.Models.Carteira;
using coincontrol.Models.Usuario;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace coincontrol.Controllers
{
    public class CarteirasController : Controller
    {
        private readonly CoinControlBdContext _context; 
        public CarteirasController(CoinControlBdContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var carteiras = _context.Carteiras.ToList();
            return View(carteiras);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(Carteira carteira)
        {
            if (ModelState.IsValid)
            {
                _context.Carteiras.Add(carteira);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(carteira);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var carteira = _context.Carteiras.Find(id);

            if (carteira == null)
                return NotFound();

            return View(carteira);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, Carteira carteira)
        {
            if (id != carteira.IdCarteira)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(carteira);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(carteira);
        }

        public IActionResult Excluir(int? id)
        {
            if (id == null)
                return NotFound();

            var carteira = _context.Carteiras.Find(id);

            if (carteira == null)
                return NotFound();

            return View(carteira);
        }

        [HttpPost, ActionName("Excluir")]
        public async Task<IActionResult> ConfirmarExclusao(int id)
        {
            var carteira = _context.Carteiras.Find(id);

            if (carteira != null)
            {
                _context.Carteiras.Remove(carteira);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

    }
}
