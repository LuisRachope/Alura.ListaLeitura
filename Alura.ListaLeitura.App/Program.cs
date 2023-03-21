using Alura.ListaLeitura.App.Model;
using Alura.ListaLeitura.App.Repositorio;
using System;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;

namespace Alura.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
