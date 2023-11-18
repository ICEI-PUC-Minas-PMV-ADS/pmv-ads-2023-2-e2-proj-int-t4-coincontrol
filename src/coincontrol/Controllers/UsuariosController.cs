using BCrypt.Net;
using coincontrol.CCDbContext;
using coincontrol.Models.Usuario;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace coincontrol.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly CoinControlBdContext _context;

        public UsuariosController(CoinControlBdContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nome,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Usuarios");
            }

            return View(usuario);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Dashboard");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Usuario dados)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == dados.Email);

            if (usuario == null)
            {
                ViewBag.Mensagem = "Usuário e/ou senha invalidos!";
                return View();
            }

            if (!SenhaValida(dados.Senha, usuario.Senha))
            {
                ViewBag.Mensagem = "Usuário e/ou senha invalidos!";
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim(ClaimTypes.NameIdentifier, usuario.Email)
            };

            var usuarioIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(usuarioIdentity);

            var props = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(principal, props);

            return RedirectToAction("Index", "Dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound();
            
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Email,Senha")] Usuario dados)
        {
            if (id != dados.idUsuario)
                return NotFound();

            if (ModelState.IsValid)
            {
                dados.Senha = BCrypt.Net.BCrypt.HashPassword(dados.Senha);
                _context.Update(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Usuarios");
            }

            return View(dados);
        }

        private static bool SenhaValida(string senhaFornecida, string senhaUsuarioDB)
        {
            return BCrypt.Net.BCrypt.Verify(senhaFornecida, senhaUsuarioDB);
        }
    }
}
