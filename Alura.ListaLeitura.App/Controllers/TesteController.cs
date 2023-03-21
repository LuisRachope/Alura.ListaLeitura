using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.ListaLeitura.App.Controllers
{
    class TesteController : Controller
    {
        public IActionResult Teste()
        {
            return View("lista");
        }
    }
}
