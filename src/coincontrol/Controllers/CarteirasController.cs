using Microsoft.AspNetCore.Mvc;

namespace coincontrol.Controllers
{
    public class CarteirasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
