using Alura.ListaLeitura.App.View;
using Alura.ListaLeitura.App.Model;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Controllers
{
    public class CadastroController : Controller
    {
        public string Mensagem { get; set; }

        public IActionResult Incluir(Livro livro)
        {
            

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            if (repo is null)
            {
                ViewBag.Mensagem = "Erro ao tentar adicionar um novo livro.";
            }

            ViewBag.Mensagem = "O livro foi adicionado com sucesso";

            return View("resposta-formulario");
        }

        public IActionResult ExibeFormulario()
        {
            return View("formulario");
        }
    }
}
