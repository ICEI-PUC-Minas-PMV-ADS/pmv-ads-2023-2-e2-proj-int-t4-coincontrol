using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models.Carteira;

namespace coincontrol.Controllers
{
    public class CarteiraController : Controller
    {
        private readonly CoinControlBdContext _context;

        public CarteiraController(CoinControlBdContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var carteiras = _context.Carteiras.ToList();
            return View(carteiras);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
     
        public async Task<IActionResult> Create(Carteiras carteira)
        {
            if (ModelState.IsValid)
            {
                _context.Carteiras.Add(carteira);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Ocorreu um erro ao criar a carteira.");
            return View(carteira);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carteira = _context.Carteiras.Find(id);

            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        [HttpPost]
       
        public async Task<IActionResult> Edit(int id, Carteiras carteiras)
        {
            if (id != carteiras.IdCarteira)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(carteiras);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Ocorreu um erro ao editar a carteira.");
            return View(carteiras);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carteira = _context.Carteiras.Find(id);

            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carteiras = _context.Carteiras.Find(id);

            if (carteiras == null)
            {
                return NotFound();
            }

            return View(carteiras);
        }
    }
}
