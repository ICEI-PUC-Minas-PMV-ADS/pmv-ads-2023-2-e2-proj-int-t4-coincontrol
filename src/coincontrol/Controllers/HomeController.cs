using coincontrol.CCDbContext;
using coincontrol.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace coincontrol.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CoinControlBdContext _context;

        public HomeController(ILogger<HomeController> logger, CoinControlBdContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var emailUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == emailUsuario);
                return View(usuario);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}