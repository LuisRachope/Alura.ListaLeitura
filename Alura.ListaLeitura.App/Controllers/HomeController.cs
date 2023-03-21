using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }
    }
}
