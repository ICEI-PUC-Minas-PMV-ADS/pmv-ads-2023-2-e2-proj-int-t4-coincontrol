using Microsoft.AspNetCore.Mvc;

namespace coincontrol.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
