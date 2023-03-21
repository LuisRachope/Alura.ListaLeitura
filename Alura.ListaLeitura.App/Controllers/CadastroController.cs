using Alura.ListaLeitura.App.View;
using Alura.ListaLeitura.App.Model;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            var html = HtmlUtils.CarregaArquivoHTML("resposta-formulario").Replace("#MENSAGEM#", "O livro foi adicionado com sucesso");

            var view = new ViewResult { ViewName = "resposta-formulario" };

            return view;
        }

        public IActionResult ExibeFormulario()
        {
            // HtmlUtils.CarregaArquivoHTML("formulario")

            var html = new ViewResult { ViewName = "formulario" };

            return html;
        }
    }
}
