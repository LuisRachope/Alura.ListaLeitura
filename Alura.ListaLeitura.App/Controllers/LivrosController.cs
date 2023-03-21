using Alura.ListaLeitura.App.View;
using Alura.ListaLeitura.App.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Repositorio;

namespace Alura.ListaLeitura.App.Controllers
{
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }
        public string Titulo { get; set; }

        public IActionResult ParaLer()
        {
            ViewBag.Titulo = "Lista de livros:";

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;

            return View("lista");
        }

        public IActionResult Lendo()
        {
            ViewBag.Titulo = "Lista de livros em andamento (Lendo):";

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;

            return View("lista");
        }

        public IActionResult Lidos()
        {
            ViewBag.Titulo = "Lista de livros lidos:";

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;

            return View("lista");
        }


        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        public string Teste()
        {
            return "Nova funcionalidade implementada!";
        }
    }
}
